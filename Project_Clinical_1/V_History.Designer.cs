namespace Project_Clinical_1
{
    partial class V_History
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P_History_DGV = new System.Windows.Forms.DataGridView();
            this.Patient_History = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Prev = new System.Windows.Forms.Button();
            this.Patient_N_H = new System.Windows.Forms.Label();
            this.P_Name = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_History_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 545);
            this.panel1.TabIndex = 87;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_Clinical_1.Properties.Resources.patient_new;
            this.pictureBox2.Location = new System.Drawing.Point(58, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 136);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Brush Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(82, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mohammed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Clinical_1.Properties.Resources.d_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 286);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // P_History_DGV
            // 
            this.P_History_DGV.AllowUserToAddRows = false;
            this.P_History_DGV.AllowUserToDeleteRows = false;
            this.P_History_DGV.BackgroundColor = System.Drawing.Color.LightCyan;
            this.P_History_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P_History_DGV.Location = new System.Drawing.Point(279, 175);
            this.P_History_DGV.Name = "P_History_DGV";
            this.P_History_DGV.ReadOnly = true;
            this.P_History_DGV.Size = new System.Drawing.Size(564, 357);
            this.P_History_DGV.TabIndex = 89;
            // 
            // Patient_History
            // 
            this.Patient_History.AutoSize = true;
            this.Patient_History.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_History.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.Patient_History.Location = new System.Drawing.Point(271, 22);
            this.Patient_History.Name = "Patient_History";
            this.Patient_History.Size = new System.Drawing.Size(280, 44);
            this.Patient_History.TabIndex = 88;
            this.Patient_History.Text = "Patient History";
            // 
            // Prev
            // 
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.ForeColor = System.Drawing.Color.LightCyan;
            this.Prev.Location = new System.Drawing.Point(760, 98);
            this.Prev.Margin = new System.Windows.Forms.Padding(4);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(83, 45);
            this.Prev.TabIndex = 90;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Patient_N_H
            // 
            this.Patient_N_H.AutoSize = true;
            this.Patient_N_H.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_N_H.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.Patient_N_H.Location = new System.Drawing.Point(275, 109);
            this.Patient_N_H.Name = "Patient_N_H";
            this.Patient_N_H.Size = new System.Drawing.Size(131, 22);
            this.Patient_N_H.TabIndex = 91;
            this.Patient_N_H.Text = "Patient Name";
            // 
            // P_Name
            // 
            this.P_Name.FormattingEnabled = true;
            this.P_Name.Location = new System.Drawing.Point(426, 113);
            this.P_Name.Name = "P_Name";
            this.P_Name.Size = new System.Drawing.Size(168, 21);
            this.P_Name.TabIndex = 92;
            // 
            // V_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(857, 545);
            this.Controls.Add(this.P_Name);
            this.Controls.Add(this.Patient_N_H);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P_History_DGV);
            this.Controls.Add(this.Patient_History);
            this.Controls.Add(this.Prev);
            this.Name = "V_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V_History";
            this.Load += new System.EventHandler(this.V_History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_History_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView P_History_DGV;
        private System.Windows.Forms.Label Patient_History;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Patient_N_H;
        private System.Windows.Forms.ComboBox P_Name;
    }
}