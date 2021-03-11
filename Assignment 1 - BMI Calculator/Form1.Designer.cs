namespace Assignment_1___BMI_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblHeightIn = new System.Windows.Forms.Label();
            this.lblHeightFt = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblWeightLbs = new System.Windows.Forms.Label();
            this.lblBodyFat = new System.Windows.Forms.Label();
            this.lblIDealWeightLbs = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbHeightFt = new System.Windows.Forms.TextBox();
            this.tbWeightLbs = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbHeightIn = new System.Windows.Forms.TextBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lblBFPD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(485, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(867, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Body Fat Percentage (BMI) Calculator";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAge.Location = new System.Drawing.Point(104, 167);
            this.lblAge.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(113, 53);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBMI.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBMI.Location = new System.Drawing.Point(104, 632);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(123, 53);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "BMI:";
            // 
            // lblHeightIn
            // 
            this.lblHeightIn.AutoSize = true;
            this.lblHeightIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHeightIn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeightIn.Location = new System.Drawing.Point(1304, 315);
            this.lblHeightIn.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblHeightIn.Name = "lblHeightIn";
            this.lblHeightIn.Size = new System.Drawing.Size(239, 53);
            this.lblHeightIn.TabIndex = 4;
            this.lblHeightIn.Text = "Height (in):";
            // 
            // lblHeightFt
            // 
            this.lblHeightFt.AutoSize = true;
            this.lblHeightFt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHeightFt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightFt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeightFt.Location = new System.Drawing.Point(104, 315);
            this.lblHeightFt.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblHeightFt.Name = "lblHeightFt";
            this.lblHeightFt.Size = new System.Drawing.Size(232, 53);
            this.lblHeightFt.TabIndex = 5;
            this.lblHeightFt.Text = "Height (ft):";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSex.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSex.Location = new System.Drawing.Point(1304, 167);
            this.lblSex.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(214, 53);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Sex (m/f):";
            // 
            // lblWeightLbs
            // 
            this.lblWeightLbs.AutoSize = true;
            this.lblWeightLbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblWeightLbs.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightLbs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeightLbs.Location = new System.Drawing.Point(104, 472);
            this.lblWeightLbs.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWeightLbs.Name = "lblWeightLbs";
            this.lblWeightLbs.Size = new System.Drawing.Size(265, 53);
            this.lblWeightLbs.TabIndex = 7;
            this.lblWeightLbs.Text = "Weight (lbs):";
            // 
            // lblBodyFat
            // 
            this.lblBodyFat.AutoSize = true;
            this.lblBodyFat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBodyFat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyFat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBodyFat.Location = new System.Drawing.Point(1141, 632);
            this.lblBodyFat.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBodyFat.Name = "lblBodyFat";
            this.lblBodyFat.Size = new System.Drawing.Size(258, 53);
            this.lblBodyFat.TabIndex = 8;
            this.lblBodyFat.Text = "Body Fat %:";
            // 
            // lblIDealWeightLbs
            // 
            this.lblIDealWeightLbs.AutoSize = true;
            this.lblIDealWeightLbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblIDealWeightLbs.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDealWeightLbs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIDealWeightLbs.Location = new System.Drawing.Point(1141, 746);
            this.lblIDealWeightLbs.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblIDealWeightLbs.Name = "lblIDealWeightLbs";
            this.lblIDealWeightLbs.Size = new System.Drawing.Size(369, 53);
            this.lblIDealWeightLbs.TabIndex = 9;
            this.lblIDealWeightLbs.Text = "Ideal Weight (lbs):";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(416, 172);
            this.tbAge.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(260, 38);
            this.tbAge.TabIndex = 10;
            this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAge_KeyPress);
            // 
            // tbHeightFt
            // 
            this.tbHeightFt.Location = new System.Drawing.Point(416, 315);
            this.tbHeightFt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbHeightFt.Name = "tbHeightFt";
            this.tbHeightFt.Size = new System.Drawing.Size(260, 38);
            this.tbHeightFt.TabIndex = 11;
            this.tbHeightFt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeightFt_KeyPress);
            // 
            // tbWeightLbs
            // 
            this.tbWeightLbs.Location = new System.Drawing.Point(416, 472);
            this.tbWeightLbs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbWeightLbs.Name = "tbWeightLbs";
            this.tbWeightLbs.Size = new System.Drawing.Size(260, 38);
            this.tbWeightLbs.TabIndex = 12;
            this.tbWeightLbs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWeightLbs_KeyPress);
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(1600, 169);
            this.tbSex.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(260, 38);
            this.tbSex.TabIndex = 13;
            // 
            // tbHeightIn
            // 
            this.tbHeightIn.Location = new System.Drawing.Point(1600, 320);
            this.tbHeightIn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbHeightIn.Name = "tbHeightIn";
            this.tbHeightIn.Size = new System.Drawing.Size(260, 38);
            this.tbHeightIn.TabIndex = 14;
            this.tbHeightIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeightIn_KeyPress);
            // 
            // btCalculate
            // 
            this.btCalculate.AutoSize = true;
            this.btCalculate.BackColor = System.Drawing.Color.Silver;
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculate.Location = new System.Drawing.Point(782, 387);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(328, 138);
            this.btCalculate.TabIndex = 15;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = false;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lblBFPD
            // 
            this.lblBFPD.AutoSize = true;
            this.lblBFPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBFPD.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBFPD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBFPD.Location = new System.Drawing.Point(104, 746);
            this.lblBFPD.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBFPD.Name = "lblBFPD";
            this.lblBFPD.Size = new System.Drawing.Size(361, 53);
            this.lblBFPD.TabIndex = 16;
            this.lblBFPD.Text = "BF% Description:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1899, 880);
            this.Controls.Add(this.lblBFPD);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbHeightIn);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.tbWeightLbs);
            this.Controls.Add(this.tbHeightFt);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lblIDealWeightLbs);
            this.Controls.Add(this.lblBodyFat);
            this.Controls.Add(this.lblWeightLbs);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblHeightFt);
            this.Controls.Add(this.lblHeightIn);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Fat Percentage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblHeightIn;
        private System.Windows.Forms.Label lblHeightFt;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblWeightLbs;
        private System.Windows.Forms.Label lblBodyFat;
        private System.Windows.Forms.Label lblIDealWeightLbs;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbHeightFt;
        private System.Windows.Forms.TextBox tbWeightLbs;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbHeightIn;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label lblBFPD;
    }
}

