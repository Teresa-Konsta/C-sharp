namespace StudentInfoSystem
{
    partial class frmStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.rbtnDomestic = new System.Windows.Forms.RadioButton();
            this.rbtnForeign = new System.Windows.Forms.RadioButton();
            this.cboProgram = new System.Windows.Forms.ComboBox();
            this.nrudSemester = new System.Windows.Forms.NumericUpDown();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.chkComp123 = new System.Windows.Forms.CheckBox();
            this.chkComp225 = new System.Windows.Forms.CheckBox();
            this.chkComp213 = new System.Windows.Forms.CheckBox();
            this.chkComp301 = new System.Windows.Forms.CheckBox();
            this.chkComp100 = new System.Windows.Forms.CheckBox();
            this.chkMath185 = new System.Windows.Forms.CheckBox();
            this.chkComp391 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnForeign);
            this.groupBox1.Controls.Add(this.rbtnDomestic);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkComp100);
            this.groupBox2.Controls.Add(this.chkMath185);
            this.groupBox2.Controls.Add(this.chkComp391);
            this.groupBox2.Controls.Add(this.chkComp301);
            this.groupBox2.Controls.Add(this.chkComp213);
            this.groupBox2.Controls.Add(this.chkComp225);
            this.groupBox2.Controls.Add(this.chkComp123);
            this.groupBox2.Controls.Add(this.txtGpa);
            this.groupBox2.Controls.Add(this.nrudSemester);
            this.groupBox2.Controls.Add(this.cboProgram);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(26, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Academic Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(598, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(721, 510);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 35);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Residence:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gpa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Courses:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Semester:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Program:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(143, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(143, 132);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(199, 22);
            this.txtCity.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(552, 42);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // rbtnDomestic
            // 
            this.rbtnDomestic.AutoSize = true;
            this.rbtnDomestic.Checked = true;
            this.rbtnDomestic.Location = new System.Drawing.Point(573, 111);
            this.rbtnDomestic.Name = "rbtnDomestic";
            this.rbtnDomestic.Size = new System.Drawing.Size(109, 26);
            this.rbtnDomestic.TabIndex = 7;
            this.rbtnDomestic.TabStop = true;
            this.rbtnDomestic.Text = "Domestic";
            this.rbtnDomestic.UseVisualStyleBackColor = true;
            // 
            // rbtnForeign
            // 
            this.rbtnForeign.AutoSize = true;
            this.rbtnForeign.Location = new System.Drawing.Point(573, 153);
            this.rbtnForeign.Name = "rbtnForeign";
            this.rbtnForeign.Size = new System.Drawing.Size(96, 26);
            this.rbtnForeign.TabIndex = 8;
            this.rbtnForeign.TabStop = true;
            this.rbtnForeign.Text = "Foreign";
            this.rbtnForeign.UseVisualStyleBackColor = true;
            // 
            // cboProgram
            // 
            this.cboProgram.FormattingEnabled = true;
            this.cboProgram.Location = new System.Drawing.Point(113, 48);
            this.cboProgram.Name = "cboProgram";
            this.cboProgram.Size = new System.Drawing.Size(636, 24);
            this.cboProgram.TabIndex = 8;
            // 
            // nrudSemester
            // 
            this.nrudSemester.Location = new System.Drawing.Point(113, 103);
            this.nrudSemester.Name = "nrudSemester";
            this.nrudSemester.Size = new System.Drawing.Size(138, 22);
            this.nrudSemester.TabIndex = 9;
            // 
            // txtGpa
            // 
            this.txtGpa.Location = new System.Drawing.Point(113, 159);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(100, 22);
            this.txtGpa.TabIndex = 10;
            // 
            // chkComp123
            // 
            this.chkComp123.AutoSize = true;
            this.chkComp123.Location = new System.Drawing.Point(531, 93);
            this.chkComp123.Name = "chkComp123";
            this.chkComp123.Size = new System.Drawing.Size(118, 26);
            this.chkComp123.TabIndex = 11;
            this.chkComp123.Text = "COMP123";
            this.chkComp123.UseVisualStyleBackColor = true;
            // 
            // chkComp225
            // 
            this.chkComp225.AutoSize = true;
            this.chkComp225.Location = new System.Drawing.Point(531, 122);
            this.chkComp225.Name = "chkComp225";
            this.chkComp225.Size = new System.Drawing.Size(118, 26);
            this.chkComp225.TabIndex = 12;
            this.chkComp225.Text = "COMP225";
            this.chkComp225.UseVisualStyleBackColor = true;
            // 
            // chkComp213
            // 
            this.chkComp213.AutoSize = true;
            this.chkComp213.Location = new System.Drawing.Point(531, 152);
            this.chkComp213.Name = "chkComp213";
            this.chkComp213.Size = new System.Drawing.Size(118, 26);
            this.chkComp213.TabIndex = 13;
            this.chkComp213.Text = "COMP213";
            this.chkComp213.UseVisualStyleBackColor = true;
            // 
            // chkComp301
            // 
            this.chkComp301.AutoSize = true;
            this.chkComp301.Location = new System.Drawing.Point(531, 179);
            this.chkComp301.Name = "chkComp301";
            this.chkComp301.Size = new System.Drawing.Size(118, 26);
            this.chkComp301.TabIndex = 14;
            this.chkComp301.Text = "COMP301";
            this.chkComp301.UseVisualStyleBackColor = true;
            // 
            // chkComp100
            // 
            this.chkComp100.AutoSize = true;
            this.chkComp100.Location = new System.Drawing.Point(651, 152);
            this.chkComp100.Name = "chkComp100";
            this.chkComp100.Size = new System.Drawing.Size(118, 26);
            this.chkComp100.TabIndex = 17;
            this.chkComp100.Text = "COMP100";
            this.chkComp100.UseVisualStyleBackColor = true;
            // 
            // chkMath185
            // 
            this.chkMath185.AutoSize = true;
            this.chkMath185.Location = new System.Drawing.Point(651, 122);
            this.chkMath185.Name = "chkMath185";
            this.chkMath185.Size = new System.Drawing.Size(116, 26);
            this.chkMath185.TabIndex = 16;
            this.chkMath185.Text = "MATH185";
            this.chkMath185.UseVisualStyleBackColor = true;
            // 
            // chkComp391
            // 
            this.chkComp391.AutoSize = true;
            this.chkComp391.Location = new System.Drawing.Point(651, 93);
            this.chkComp391.Name = "chkComp391";
            this.chkComp391.Size = new System.Drawing.Size(118, 26);
            this.chkComp391.TabIndex = 15;
            this.chkComp391.Text = "COMP391";
            this.chkComp391.UseVisualStyleBackColor = true;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 569);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudent";
            this.Text = "Student Info System";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudSemester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtnForeign;
        private System.Windows.Forms.RadioButton rbtnDomestic;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtGpa;
        private System.Windows.Forms.NumericUpDown nrudSemester;
        private System.Windows.Forms.ComboBox cboProgram;
        private System.Windows.Forms.CheckBox chkComp100;
        private System.Windows.Forms.CheckBox chkMath185;
        private System.Windows.Forms.CheckBox chkComp391;
        private System.Windows.Forms.CheckBox chkComp301;
        private System.Windows.Forms.CheckBox chkComp213;
        private System.Windows.Forms.CheckBox chkComp225;
        private System.Windows.Forms.CheckBox chkComp123;
    }
}

