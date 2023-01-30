namespace Project_Clinical_1
{
    partial class Derma_Medical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Medical_Record = new System.Windows.Forms.Button();
            this.Allergies = new System.Windows.Forms.RichTextBox();
            this.Prescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.P_Age = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Type_of_Session = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.Add_Photo = new System.Windows.Forms.Button();
            this.P_Name = new System.Windows.Forms.ComboBox();
            this.P_Gender = new System.Windows.Forms.ComboBox();
            this.P_M_R_Photo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_M_R_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Medical_Record
            // 
            this.Add_Medical_Record.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_Medical_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Medical_Record.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Medical_Record.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_Medical_Record.Location = new System.Drawing.Point(720, 455);
            this.Add_Medical_Record.Name = "Add_Medical_Record";
            this.Add_Medical_Record.Size = new System.Drawing.Size(110, 38);
            this.Add_Medical_Record.TabIndex = 80;
            this.Add_Medical_Record.Text = "Add";
            this.Add_Medical_Record.UseVisualStyleBackColor = true;
            this.Add_Medical_Record.Click += new System.EventHandler(this.Add_Medical_Record_Click);
            // 
            // Allergies
            // 
            this.Allergies.BackColor = System.Drawing.Color.LightCyan;
            this.Allergies.Location = new System.Drawing.Point(266, 257);
            this.Allergies.Name = "Allergies";
            this.Allergies.Size = new System.Drawing.Size(233, 96);
            this.Allergies.TabIndex = 78;
            this.Allergies.Text = "";
            // 
            // Prescription
            // 
            this.Prescription.BackColor = System.Drawing.Color.LightCyan;
            this.Prescription.Location = new System.Drawing.Point(576, 257);
            this.Prescription.Name = "Prescription";
            this.Prescription.Size = new System.Drawing.Size(233, 139);
            this.Prescription.TabIndex = 77;
            this.Prescription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Location = new System.Drawing.Point(256, -86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 44);
            this.label8.TabIndex = 76;
            this.label8.Text = "Medical Record";
            // 
            // P_Age
            // 
            this.P_Age.Location = new System.Drawing.Point(578, 181);
            this.P_Age.Margin = new System.Windows.Forms.Padding(4);
            this.P_Age.Name = "P_Age";
            this.P_Age.Size = new System.Drawing.Size(233, 20);
            this.P_Age.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightCyan;
            this.label9.Location = new System.Drawing.Point(572, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 24);
            this.label9.TabIndex = 72;
            this.label9.Text = "Prescription :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Type_of_Session
            // 
            this.Type_of_Session.FormattingEnabled = true;
            this.Type_of_Session.Items.AddRange(new object[] {
            "Dermatology",
            "Plastic Surgery"});
            this.Type_of_Session.Location = new System.Drawing.Point(264, 181);
            this.Type_of_Session.Name = "Type_of_Session";
            this.Type_of_Session.Size = new System.Drawing.Size(233, 21);
            this.Type_of_Session.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCyan;
            this.label5.Location = new System.Drawing.Point(260, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "Type of Session :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCyan;
            this.label6.Location = new System.Drawing.Point(572, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 69;
            this.label6.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(574, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 68;
            this.label2.Text = "Age :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(260, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Allergies :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(60, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Docotr Menna";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightCyan;
            this.label7.Location = new System.Drawing.Point(260, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Patient Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 815);
            this.panel1.TabIndex = 64;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_Clinical_1.Properties.Resources.doctor13;
            this.pictureBox3.Location = new System.Drawing.Point(53, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 131);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Clinical_1.Properties.Resources.d_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 403);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Location = new System.Drawing.Point(256, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 44);
            this.label4.TabIndex = 81;
            this.label4.Text = "Medical Record";
            // 
            // Prev
            // 
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.ForeColor = System.Drawing.Color.LightCyan;
            this.Prev.Location = new System.Drawing.Point(728, 19);
            this.Prev.Margin = new System.Windows.Forms.Padding(4);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(83, 45);
            this.Prev.TabIndex = 86;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Add_Photo
            // 
            this.Add_Photo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_Photo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Photo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Photo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_Photo.Location = new System.Drawing.Point(401, 439);
            this.Add_Photo.Name = "Add_Photo";
            this.Add_Photo.Size = new System.Drawing.Size(96, 54);
            this.Add_Photo.TabIndex = 87;
            this.Add_Photo.Text = "Add Photo";
            this.Add_Photo.UseVisualStyleBackColor = true;
            this.Add_Photo.Click += new System.EventHandler(this.Add_Photo_Click);
            // 
            // P_Name
            // 
            this.P_Name.FormattingEnabled = true;
            this.P_Name.Location = new System.Drawing.Point(264, 107);
            this.P_Name.Name = "P_Name";
            this.P_Name.Size = new System.Drawing.Size(233, 21);
            this.P_Name.TabIndex = 88;
            this.P_Name.SelectedIndexChanged += new System.EventHandler(this.P_Name_SelectedIndexChanged);
            // 
            // P_Gender
            // 
            this.P_Gender.FormattingEnabled = true;
            this.P_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.P_Gender.Location = new System.Drawing.Point(576, 107);
            this.P_Gender.Name = "P_Gender";
            this.P_Gender.Size = new System.Drawing.Size(235, 21);
            this.P_Gender.TabIndex = 89;
            // 
            // P_M_R_Photo
            // 
            this.P_M_R_Photo.Location = new System.Drawing.Point(264, 359);
            this.P_M_R_Photo.Name = "P_M_R_Photo";
            this.P_M_R_Photo.Size = new System.Drawing.Size(131, 134);
            this.P_M_R_Photo.TabIndex = 90;
            this.P_M_R_Photo.TabStop = false;
            // 
            // Derma_Medical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(842, 505);
            this.Controls.Add(this.P_M_R_Photo);
            this.Controls.Add(this.P_Gender);
            this.Controls.Add(this.P_Name);
            this.Controls.Add(this.Add_Photo);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Add_Medical_Record);
            this.Controls.Add(this.Allergies);
            this.Controls.Add(this.Prescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.P_Age);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Type_of_Session);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Derma_Medical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Derma_Medical";
            this.Load += new System.EventHandler(this.Derma_Medical_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_M_R_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Medical_Record;
        private System.Windows.Forms.RichTextBox Allergies;
        private System.Windows.Forms.RichTextBox Prescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox P_Age;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Type_of_Session;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Add_Photo;
        private System.Windows.Forms.ComboBox P_Name;
        private System.Windows.Forms.ComboBox P_Gender;
        private System.Windows.Forms.PictureBox P_M_R_Photo;
    }
}