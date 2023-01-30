namespace Project_Clinical_1
{
    partial class History
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Prev = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Chronic_Disease = new System.Windows.Forms.Label();
            this.Medications = new System.Windows.Forms.TextBox();
            this.Medication = new System.Windows.Forms.Label();
            this.Past_Surgries = new System.Windows.Forms.TextBox();
            this.Past_Surgical = new System.Windows.Forms.Label();
            this.Allergies = new System.Windows.Forms.Label();
            this.Chronic_Diseases = new System.Windows.Forms.ComboBox();
            this.Dermatologic_Disease = new System.Windows.Forms.ComboBox();
            this.Dermatologic_diseases = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.P_Age = new System.Windows.Forms.TextBox();
            this.Patient_Age = new System.Windows.Forms.Label();
            this.Add_History = new System.Windows.Forms.Button();
            this.P_Name = new System.Windows.Forms.ComboBox();
            this.Allergy = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.Prev);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 415);
            this.panel1.TabIndex = 32;
            // 
            // Prev
            // 
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Prev.Location = new System.Drawing.Point(173, 365);
            this.Prev.Margin = new System.Windows.Forms.Padding(4);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(83, 50);
            this.Prev.TabIndex = 84;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_Clinical_1.Properties.Resources.profile__1__removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(63, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 129);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(74, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patient History";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Clinical_1.Properties.Resources.d_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 190);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Location = new System.Drawing.Point(271, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 44);
            this.label8.TabIndex = 33;
            this.label8.Text = "History";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Chronic_Disease
            // 
            this.Chronic_Disease.AutoSize = true;
            this.Chronic_Disease.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chronic_Disease.ForeColor = System.Drawing.Color.LightCyan;
            this.Chronic_Disease.Location = new System.Drawing.Point(284, 161);
            this.Chronic_Disease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Chronic_Disease.Name = "Chronic_Disease";
            this.Chronic_Disease.Size = new System.Drawing.Size(181, 24);
            this.Chronic_Disease.TabIndex = 34;
            this.Chronic_Disease.Text = "Chronic_Disease";
            this.Chronic_Disease.Click += new System.EventHandler(this.label4_Click);
            // 
            // Medications
            // 
            this.Medications.Location = new System.Drawing.Point(645, 189);
            this.Medications.Margin = new System.Windows.Forms.Padding(4);
            this.Medications.Name = "Medications";
            this.Medications.Size = new System.Drawing.Size(233, 20);
            this.Medications.TabIndex = 37;
            // 
            // Medication
            // 
            this.Medication.AutoSize = true;
            this.Medication.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication.ForeColor = System.Drawing.Color.LightCyan;
            this.Medication.Location = new System.Drawing.Point(641, 161);
            this.Medication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Medication.Name = "Medication";
            this.Medication.Size = new System.Drawing.Size(119, 24);
            this.Medication.TabIndex = 36;
            this.Medication.Text = "Medication";
            // 
            // Past_Surgries
            // 
            this.Past_Surgries.Location = new System.Drawing.Point(288, 262);
            this.Past_Surgries.Margin = new System.Windows.Forms.Padding(4);
            this.Past_Surgries.Name = "Past_Surgries";
            this.Past_Surgries.Size = new System.Drawing.Size(233, 20);
            this.Past_Surgries.TabIndex = 39;
            // 
            // Past_Surgical
            // 
            this.Past_Surgical.AutoSize = true;
            this.Past_Surgical.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Past_Surgical.ForeColor = System.Drawing.Color.LightCyan;
            this.Past_Surgical.Location = new System.Drawing.Point(284, 234);
            this.Past_Surgical.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Past_Surgical.Name = "Past_Surgical";
            this.Past_Surgical.Size = new System.Drawing.Size(149, 24);
            this.Past_Surgical.TabIndex = 38;
            this.Past_Surgical.Text = "Past_Surgical";
            // 
            // Allergies
            // 
            this.Allergies.AutoSize = true;
            this.Allergies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allergies.ForeColor = System.Drawing.Color.LightCyan;
            this.Allergies.Location = new System.Drawing.Point(641, 234);
            this.Allergies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Allergies.Name = "Allergies";
            this.Allergies.Size = new System.Drawing.Size(97, 24);
            this.Allergies.TabIndex = 40;
            this.Allergies.Text = "Allergies";
            // 
            // Chronic_Diseases
            // 
            this.Chronic_Diseases.AutoCompleteCustomSource.AddRange(new string[] {
            "Dibetes",
            "Blood Pressure",
            "Cardiac",
            "Neuro",
            "Mental"});
            this.Chronic_Diseases.FormattingEnabled = true;
            this.Chronic_Diseases.Items.AddRange(new object[] {
            "Heart Disease",
            "Cancer",
            "Chronic Lung Disease",
            "Stroke",
            "Alzheimer\'s",
            "Diabetes",
            "Chronic Kidney Disease"});
            this.Chronic_Diseases.Location = new System.Drawing.Point(288, 189);
            this.Chronic_Diseases.Name = "Chronic_Diseases";
            this.Chronic_Diseases.Size = new System.Drawing.Size(233, 21);
            this.Chronic_Diseases.TabIndex = 42;
            // 
            // Dermatologic_Disease
            // 
            this.Dermatologic_Disease.AutoCompleteCustomSource.AddRange(new string[] {
            "Acne",
            "Alopecia Areata ",
            "Atopic Dermaititis",
            "Epidermolysis Bullosa",
            "Hidradenitis Suppurativa",
            "Icthyosis",
            "Pachyonychia Congenita",
            "Pemphigus",
            "Psoriasis"});
            this.Dermatologic_Disease.FormattingEnabled = true;
            this.Dermatologic_Disease.Items.AddRange(new object[] {
            "Acne",
            "Alopecia Areata",
            "Atopic Dermatitis",
            "Epidermolysis Bullosa",
            "Hidradenitis Suppurativa (HS)",
            "Ichthyosis",
            "Pachyonychia Congenita",
            "Pemphigus"});
            this.Dermatologic_Disease.Location = new System.Drawing.Point(288, 332);
            this.Dermatologic_Disease.Name = "Dermatologic_Disease";
            this.Dermatologic_Disease.Size = new System.Drawing.Size(233, 21);
            this.Dermatologic_Disease.TabIndex = 44;
            // 
            // Dermatologic_diseases
            // 
            this.Dermatologic_diseases.AutoSize = true;
            this.Dermatologic_diseases.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dermatologic_diseases.ForeColor = System.Drawing.Color.LightCyan;
            this.Dermatologic_diseases.Location = new System.Drawing.Point(284, 304);
            this.Dermatologic_diseases.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dermatologic_diseases.Name = "Dermatologic_diseases";
            this.Dermatologic_diseases.Size = new System.Drawing.Size(246, 24);
            this.Dermatologic_diseases.TabIndex = 43;
            this.Dermatologic_diseases.Text = "Dermatologic_diseases";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(284, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Patient Name";
            // 
            // P_Age
            // 
            this.P_Age.Location = new System.Drawing.Point(645, 116);
            this.P_Age.Margin = new System.Windows.Forms.Padding(4);
            this.P_Age.Name = "P_Age";
            this.P_Age.Size = new System.Drawing.Size(233, 20);
            this.P_Age.TabIndex = 48;
            // 
            // Patient_Age
            // 
            this.Patient_Age.AutoSize = true;
            this.Patient_Age.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Age.ForeColor = System.Drawing.Color.LightCyan;
            this.Patient_Age.Location = new System.Drawing.Point(641, 90);
            this.Patient_Age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Patient_Age.Name = "Patient_Age";
            this.Patient_Age.Size = new System.Drawing.Size(125, 24);
            this.Patient_Age.TabIndex = 47;
            this.Patient_Age.Text = "Patient Age";
            // 
            // Add_History
            // 
            this.Add_History.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_History.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_History.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Add_History.Location = new System.Drawing.Point(768, 365);
            this.Add_History.Name = "Add_History";
            this.Add_History.Size = new System.Drawing.Size(110, 38);
            this.Add_History.TabIndex = 83;
            this.Add_History.Text = "Add";
            this.Add_History.UseVisualStyleBackColor = true;
            this.Add_History.Click += new System.EventHandler(this.Add_History_Click);
            // 
            // P_Name
            // 
            this.P_Name.FormattingEnabled = true;
            this.P_Name.Location = new System.Drawing.Point(288, 117);
            this.P_Name.Name = "P_Name";
            this.P_Name.Size = new System.Drawing.Size(233, 21);
            this.P_Name.TabIndex = 90;
            // 
            // Allergy
            // 
            this.Allergy.BackColor = System.Drawing.Color.LightCyan;
            this.Allergy.Location = new System.Drawing.Point(645, 261);
            this.Allergy.Name = "Allergy";
            this.Allergy.Size = new System.Drawing.Size(233, 69);
            this.Allergy.TabIndex = 95;
            this.Allergy.Text = "";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(911, 415);
            this.Controls.Add(this.Allergy);
            this.Controls.Add(this.P_Name);
            this.Controls.Add(this.Add_History);
            this.Controls.Add(this.P_Age);
            this.Controls.Add(this.Patient_Age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dermatologic_Disease);
            this.Controls.Add(this.Dermatologic_diseases);
            this.Controls.Add(this.Chronic_Diseases);
            this.Controls.Add(this.Allergies);
            this.Controls.Add(this.Past_Surgries);
            this.Controls.Add(this.Past_Surgical);
            this.Controls.Add(this.Medications);
            this.Controls.Add(this.Medication);
            this.Controls.Add(this.Chronic_Disease);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Chronic_Disease;
        private System.Windows.Forms.TextBox Medications;
        private System.Windows.Forms.Label Medication;
        private System.Windows.Forms.TextBox Past_Surgries;
        private System.Windows.Forms.Label Past_Surgical;
        private System.Windows.Forms.Label Allergies;
        private System.Windows.Forms.ComboBox Chronic_Diseases;
        private System.Windows.Forms.ComboBox Dermatologic_Disease;
        private System.Windows.Forms.Label Dermatologic_diseases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox P_Age;
        private System.Windows.Forms.Label Patient_Age;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Add_History;
        private System.Windows.Forms.ComboBox P_Name;
        private System.Windows.Forms.RichTextBox Allergy;
    }
}