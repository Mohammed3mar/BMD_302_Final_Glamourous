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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            /*
            if (User_Name.Text == "" && Password.Text == "")
                MessageBox.Show("Enter The UserName And Password");
            else
            {
                if (Role.SelectedItem.ToString() == "Admin")
                    if (User_Name.Text == "mohammed" && Password.Text == "20200")
                    {
                        Admin ad = new Admin();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If You are the Admin, Enter The Correct Id and Password !");

                    }
                else if (Role.SelectedItem.ToString() == "Nurse")
                    if (User_Name.Text == "Reem" && Password.Text == "Reem")
                    {
                        Nurse nu = new Nurse();
                        nu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If You are the Nurse, Enter The Correct Id and Password !");

                    }
                else if (Role.SelectedItem.ToString() == "Receptionist")
                    if (User_Name.Text == "Omnia" && Password.Text == "Omnia")
                    {
                        Receptionist rc = new Receptionist();
                        rc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If You are the Receptionist, Enter The Correct Id and Password !");

                    }
                else if (Role.SelectedItem.ToString() == "Doctor")
                    if (User_Name.Text == "Mohammed" && Password.Text == "Mohammed")
                    {
                        Doctor dr = new Doctor();
                        dr.Show();
                        this.Hide();
                    }
                    else if (User_Name.Text == "Sara" && Password.Text == "Sara")
                    {
                        Doctor_Derma dc = new Doctor_Derma();
                        dc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If You are the Doctor, Enter The Correct Id and Password !");

                    }
            }
            */

            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();

            if (Role.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Your Position");
            }
            else if (Role.SelectedIndex == 0)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Doctor Name and Password");
                }

                else
                {
                    Con.Open();
                    string query = "Select * From DoctorTBL Where D_User_Name  ='" + User_Name.Text.Trim() + "' and D_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Doctor dr = new Doctor();
                        dr.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Doctor Not Found!");
                    }
                    Con.Close();
                }

            }
            else if (Role.SelectedIndex == 1)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Doctor Name and Password");
                }

                else
                {
                    Con.Open();
                    string query = "Select * From DoctorTBL Where D_User_Name  ='" + User_Name.Text.Trim() + "' and D_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Doctor_Derma dc = new Doctor_Derma();
                        dc.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Doctor Not Found!");
                    }
                    Con.Close();
                }
            }
            else if (Role.SelectedIndex == 2)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Nurse Name and Password");
                }

                else
                {
                    Con.Open();
                    string query = "Select * From NurseTBL Where N_User_Name='" + User_Name.Text.Trim() + "' and N_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Nurse nu = new Nurse();
                        nu.Show();
                        this.Hide(); ;
                    }
                    else
                    {
                        MessageBox.Show("Nurse Not Found!");
                    }
                    Con.Close();
                }
            }

            else if (Role.SelectedIndex == 3)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Receptionest Name and Password");
                }

                else
                {
                    Con.Open();
                    string query = "Select * From ReceptionistTBL Where R_User_Name='" + User_Name.Text.Trim() + "' and R_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Receptionist rc = new Receptionist();
                        rc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receptionest Not Found!");
                    }
                    Con.Close();
                }
            }
            else if (Role.SelectedIndex == 4)
            {
                if (User_Name.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please Enter Both Admin Name and Password");
                }
                else
                {
                    Con.Open();
                    string query = "Select * From AdminTBL Where A_User_Name='" + User_Name.Text.Trim() + "' and A_Password ='" + Password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Admin ad = new Admin();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Name or Password!");
                    }
                    Con.Close();
                }
            }
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
