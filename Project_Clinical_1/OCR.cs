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
using Patagames.Ocr;

namespace Project_Clinical_1
{
    public partial class OCR : Form
    {
        public OCR()
        {
            InitializeComponent();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Hide();
        }

        private void Add_Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OCR_Photo.Image = new Bitmap(openFileDialog.FileName);
                // image file path  
                Image_Path.Text = openFileDialog.FileName;
            }
        }

        private void Convert_to_Text_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(Image_Path.Text);
                OCR_Text.Text = plainText;
            }
        }

        private void OCR_Load(object sender, EventArgs e)
        {

        }
    }
}
