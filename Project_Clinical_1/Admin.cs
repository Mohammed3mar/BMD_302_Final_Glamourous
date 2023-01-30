using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;


namespace Project_Clinical_1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Nurse_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            
        }

        private void Receptionist_Click(object sender, EventArgs e)
        {

        }

        private void Add_Doctor_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs_Doctor())
            {
                MessageBox.Show("Please check the input filled");
            }
            else
            {
                ConnectionString MyConnection = new ConnectionString();
                SqlConnection Con = MyConnection.GetCon();

                string query = "insert into DoctorTBL values('" + D_Name.Text + "','" + D_Age.Text + "','" + D_Phone_Number.Text + "','" + D_Gender.Text + "','" + D_User_Name.Text + "', '" + D_Password.Text + "', '" + D_Speciality.Text + "')";
                Admincls ad = new Admincls();
                try
                {
                    ad.AddDoctor(query);
                    MessageBox.Show("Doctor Successfully Added");

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                Admincls dc = new Admincls();
                string qury = "select * from DoctorTBL";
                DataSet ds = dc.ShowDctor(qury);
                Doctor_DGV.DataSource = ds.Tables[0];

                try
                {
                    Con.Open();
                    DataSet des = new DataSet();
                    string DName = "SELECT D_Name FROM DoctorTBL";
                    SqlDataAdapter sda = new SqlDataAdapter(DName, Con);
                    sda.Fill(des);
                    D_NameCB.DataSource = des.Tables[0];
                    D_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Loading Doctor Name" + ex);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void View_Doctors_Click(object sender, EventArgs e)
        {
            Admincls dc = new Admincls();
            string query = "select * from DoctorTBL";
            DataSet ds = dc.ShowDctor(query);
            Doctor_DGV.DataSource = ds.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void Doctor_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            D_ID.Text = Doctor_DGV.SelectedRows[0].Cells[0].Value.ToString();
            D_Name.Text = Doctor_DGV.SelectedRows[0].Cells[1].Value.ToString();
            D_Speciality.Text = Doctor_DGV.SelectedRows[0].Cells[7].Value.ToString();
            D_User_Name.Text = Doctor_DGV.SelectedRows[0].Cells[5].Value.ToString();
            D_Gender.Text = Doctor_DGV.SelectedRows[0].Cells[4].Value.ToString();
            D_Phone_Number.Text = Doctor_DGV.SelectedRows[0].Cells[3].Value.ToString();
            D_Age.Text = Doctor_DGV.SelectedRows[0].Cells[2].Value.ToString();
            D_Password.Text = Doctor_DGV.SelectedRows[0].Cells[6].Value.ToString();

            if (D_Name.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Doctor_DGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        ConnectionString MyCon = new ConnectionString();
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
            D_NameCB.ValueMember = "D_Name";
            D_NameCB.DataSource = dt;
            Con.Close();
        }

        private void fillNurse()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select N_Name from NurseTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("N_Name", typeof(string));
            dt.Load(rdr);
            Nurse_NameCB.ValueMember = "N_Name";
            Nurse_NameCB.DataSource = dt;
            Con.Close();
        }

        private void fillReceptionist()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select R_Name from ReceptionistTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("R_Name", typeof(string));
            dt.Load(rdr);
            R_NameCB.ValueMember = "R_Name";
            R_NameCB.DataSource = dt;
            Con.Close();
        }

        private void Delete_Doctor_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand del = new SqlCommand("DELETE FROM [DoctorTBL] WHERE D_Name = '" + D_NameCB.Text + "'", Con);
                del.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                Con.Close();
            }

            Admincls dc = new Admincls();
            string query = "select * from DoctorTBL";
            DataSet ds = dc.ShowDctor(query);
            Doctor_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string DName = "SELECT D_Name FROM DoctorTBL";
                SqlDataAdapter sda = new SqlDataAdapter(DName, Con);
                sda.Fill(des);
                D_NameCB.DataSource = des.Tables[0];
                D_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Loading Doctor Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }

        int key = 0;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            N_ID.Text = Nurse_DGV.SelectedRows[0].Cells[0].Value.ToString();
            N_Name.Text = Nurse_DGV.SelectedRows[0].Cells[1].Value.ToString();
            N_User_Name.Text = Nurse_DGV.SelectedRows[0].Cells[5].Value.ToString();
            N_Gender.Text = Nurse_DGV.SelectedRows[0].Cells[4].Value.ToString();
            N_Phone_Number.Text = Nurse_DGV.SelectedRows[0].Cells[3].Value.ToString();
            N_Age.Text = Nurse_DGV.SelectedRows[0].Cells[2].Value.ToString();
            N_Password.Text = Nurse_DGV.SelectedRows[0].Cells[6].Value.ToString();

            if (N_Name.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Nurse_DGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void View_Nurses_Click(object sender, EventArgs e)
        {
            Admincls nr = new Admincls();
            string query = "select * from NurseTBL";
            DataSet ds = nr.ShowNurse(query);
            Nurse_DGV.DataSource = ds.Tables[0];
        }

        private void Add_Nurse_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs_Nurse())
            {
                MessageBox.Show("Please check the input filled");
            }
            else
            {
                ConnectionString MyConnection = new ConnectionString();
                SqlConnection Con = MyConnection.GetCon();

                string query = "insert into NurseTBL values('" + N_Name.Text + "','" + N_Age.Text + "','" + N_Phone_Number.Text + "','" + N_Gender.Text + "','" + N_User_Name.Text + "', '" + N_Password.Text + "')";
                Admincls ad = new Admincls();
                try
                {
                    ad.AddNurse(query);
                    MessageBox.Show("Nurse Successfully Added");

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                Admincls nr = new Admincls();
                string qery = "select * from NurseTBL";
                DataSet ds = nr.ShowNurse(qery);
                Nurse_DGV.DataSource = ds.Tables[0];

                try
                {
                    Con.Open();
                    DataSet des = new DataSet();
                    string NName = "SELECT N_Name FROM NurseTBL";
                    SqlDataAdapter sda = new SqlDataAdapter(NName, Con);
                    sda.Fill(des);
                    Nurse_NameCB.DataSource = des.Tables[0];
                    Nurse_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
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

        private void Delete_Nurse_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand del = new SqlCommand("DELETE FROM [NurseTBL] WHERE N_Name = '" + Nurse_NameCB.Text + "'", Con);
                del.ExecuteNonQuery();
                MessageBox.Show("Nurse Successfully Deleted");
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
            string query = "select * from NurseTBL";
            DataSet ds = dc.ShowNurse(query);
            Nurse_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string NName = "SELECT N_Name FROM NurseTBL";
                SqlDataAdapter sda = new SqlDataAdapter(NName, Con);
                sda.Fill(des);
                Nurse_NameCB.DataSource = des.Tables[0];
                Nurse_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
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

        private void Prev_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }

        private void Add_Receptionist_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs_R())
            {
                MessageBox.Show("Please check the input filled");
            }
            else
            {
                ConnectionString MyConnection = new ConnectionString();
                SqlConnection Con = MyConnection.GetCon();

                string query = "insert into ReceptionistTBL values('" + R_Name.Text + "','" + R_Age.Text + "','" + R_Phone_Number.Text + "','" + R_Gender.Text + "','" + R_User_Name.Text + "', '" + R_Password.Text + "')";
                Admincls ad = new Admincls();
                try
                {
                    ad.AddReceptionist(query);
                    MessageBox.Show("Receptionist Successfully Added");

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                Admincls dc = new Admincls();
                string qry = "select * from ReceptionistTBL";
                DataSet ds = dc.ShowReceptionist(qry);
                Receptionist_DGV.DataSource = ds.Tables[0];

                try
                {
                    Con.Open();
                    DataSet des = new DataSet();
                    string RName = "SELECT R_Name FROM ReceptionistTBL";
                    SqlDataAdapter sda = new SqlDataAdapter(RName, Con);
                    sda.Fill(des);
                    R_NameCB.DataSource = des.Tables[0];
                    R_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Loading Receptionist Name" + ex);
                }
                finally
                {
                    Con.Close();
                }
            }            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            fillDoctor();
            fillNurse();
            fillReceptionist();
        }

        private void View_Receptionist_Click(object sender, EventArgs e)
        {
            Admincls rc = new Admincls();
            string query = "select * from ReceptionistTBL";
            DataSet ds = rc.ShowDctor(query);
            Receptionist_DGV.DataSource = ds.Tables[0];
        }

        private void D_NameCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nurse_NameCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Receptionist_Click_1(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand del = new SqlCommand("DELETE FROM [ReceptionistTBL] WHERE R_Name = '" + R_NameCB.Text + "'", Con);
                del.ExecuteNonQuery();
                MessageBox.Show("Receptionist Successfully Deleted");
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
            string query = "select * from ReceptionistTBL";
            DataSet ds = dc.ShowNurse(query);
            Receptionist_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string RName = "SELECT R_Name FROM ReceptionistTBL";
                SqlDataAdapter sda = new SqlDataAdapter(RName, Con);
                sda.Fill(des);
                R_NameCB.DataSource = des.Tables[0];
                R_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
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

        private void D_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update DoctorTBL set D_Name='" + D_Name.Text + "',D_Password ='" + D_Password.Text + "',D_User_Name='" + D_User_Name.Text + "',D_Age='" + D_Age.Text + "' where D_ID='" + D_ID.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully.");
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
            string qury = "select * from DoctorTBL";
            DataSet ds = dc.ShowDctor(qury);
            Doctor_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string DName = "SELECT D_Name FROM DoctorTBL";
                SqlDataAdapter sda = new SqlDataAdapter(DName, Con);
                sda.Fill(des);
                D_NameCB.DataSource = des.Tables[0];
                D_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Doctor Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }

        private void N_Update_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update NurseTBL set N_Name='" + N_Name.Text + "',N_Password ='" + N_Password.Text + "',N_User_Name='" + N_User_Name.Text + "',N_Age='" + N_Age.Text + "' where N_ID='" + N_ID.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully.");
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
            Admincls nr = new Admincls();
            string qery = "select * from NurseTBL";
            DataSet ds = nr.ShowNurse(qery);
            Nurse_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string NName = "SELECT N_Name FROM NurseTBL";
                SqlDataAdapter sda = new SqlDataAdapter(NName, Con);
                sda.Fill(des);
                Nurse_NameCB.DataSource = des.Tables[0];
                Nurse_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
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

        private void R_Update_Click(object sender, EventArgs e)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ReceptionistTBL set R_Name='" + R_Name.Text + "',R_Password ='" + R_Password.Text + "',R_User_Name='" + R_User_Name.Text + "',R_Age='" + R_Age.Text + "' where R_ID='" + R_ID.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully.");
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
            string qry = "select * from ReceptionistTBL";
            DataSet ds = dc.ShowReceptionist(qry);
            Receptionist_DGV.DataSource = ds.Tables[0];

            try
            {
                Con.Open();
                DataSet des = new DataSet();
                string RName = "SELECT R_Name FROM ReceptionistTBL";
                SqlDataAdapter sda = new SqlDataAdapter(RName, Con);
                sda.Fill(des);
                R_NameCB.DataSource = des.Tables[0];
                R_NameCB.DisplayMember = des.Tables[0].Columns[0].ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Receptionist Name" + ex);
            }
            finally
            {
                Con.Close();
            }
        }

        int key1 = 0;
        private void Receptionist_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            R_ID.Text = Receptionist_DGV.SelectedRows[0].Cells[0].Value.ToString();
            R_Name.Text = Receptionist_DGV.SelectedRows[0].Cells[1].Value.ToString();
            R_User_Name.Text = Receptionist_DGV.SelectedRows[0].Cells[5].Value.ToString();
            R_Gender.Text = Receptionist_DGV.SelectedRows[0].Cells[4].Value.ToString();
            R_Phone_Number.Text = Receptionist_DGV.SelectedRows[0].Cells[3].Value.ToString();
            R_Age.Text = Receptionist_DGV.SelectedRows[0].Cells[2].Value.ToString();
            R_Password.Text = Receptionist_DGV.SelectedRows[0].Cells[6].Value.ToString();

            if (R_Name.Text == "")
            {
                key1 = 0;
            }
            else
            {
                key1 = Convert.ToInt32(Receptionist_DGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private bool ValidateInputs_Doctor()
        {
            if (D_Age.Text == "" || D_Name.Text == "" || D_Phone_Number.Text == "" || D_Password.Text == "" || D_User_Name.Text == "")
                return false;
            if (D_Speciality.SelectedIndex < 0)
                return false;
            if (D_NameCB.SelectedIndex < 0)
                return false;
            return true;
        }
        private bool ValidateInputs_Nurse()
        {
            if (N_Age.Text == "" || N_Name.Text == "" || N_Phone_Number.Text == "" || N_Password.Text == "" || N_User_Name.Text == "")
                return false;
            if (Nurse_NameCB.SelectedIndex < 0)
                return false; return true;
        }
        private bool ValidateInputs_R()
        {
            if (R_Age.Text == "" || R_Name.Text == "" || R_Phone_Number.Text == "" || R_Password.Text == "" || R_User_Name.Text == "")
                return false; if (R_NameCB.SelectedIndex < 0)
                return false; return true;
        }
    }
}
