namespace exercise_11
{
    partial class frmCalculator
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.rbtnPlus = new System.Windows.Forms.RadioButton();
            this.rbtnMinus = new System.Windows.Forms.RadioButton();
            this.rbtnMultiply = new System.Windows.Forms.RadioButton();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.btnPerform = new System.Windows.Forms.Button();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.AccessibleName = "";
            this.txtFirst.Location = new System.Drawing.Point(48, 109);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 22);
            this.txtFirst.TabIndex = 0;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(320, 109);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 22);
            this.txtSecond.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(493, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(45, 74);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(39, 17);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "First:";
            this.lblFirst.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(317, 74);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(60, 17);
            this.lblSecond.TabIndex = 4;
            this.lblSecond.Text = "Second:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(490, 74);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(450, 112);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(16, 17);
            this.lblEqual.TabIndex = 6;
            this.lblEqual.Text = "=";
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.rbtnDivide);
            this.grpAction.Controls.Add(this.rbtnMultiply);
            this.grpAction.Controls.Add(this.rbtnMinus);
            this.grpAction.Controls.Add(this.rbtnPlus);
            this.grpAction.Location = new System.Drawing.Point(172, 74);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(142, 228);
            this.grpAction.TabIndex = 7;
            this.grpAction.TabStop = false;
            // 
            // rbtnPlus
            // 
            this.rbtnPlus.AutoSize = true;
            this.rbtnPlus.Location = new System.Drawing.Point(16, 33);
            this.rbtnPlus.Name = "rbtnPlus";
            this.rbtnPlus.Size = new System.Drawing.Size(37, 21);
            this.rbtnPlus.TabIndex = 0;
            this.rbtnPlus.TabStop = true;
            this.rbtnPlus.Text = "+";
            this.rbtnPlus.UseVisualStyleBackColor = true;
            // 
            // rbtnMinus
            // 
            this.rbtnMinus.AutoSize = true;
            this.rbtnMinus.Location = new System.Drawing.Point(16, 84);
            this.rbtnMinus.Name = "rbtnMinus";
            this.rbtnMinus.Size = new System.Drawing.Size(34, 21);
            this.rbtnMinus.TabIndex = 1;
            this.rbtnMinus.TabStop = true;
            this.rbtnMinus.Text = "-";
            this.rbtnMinus.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiply
            // 
            this.rbtnMultiply.AutoSize = true;
            this.rbtnMultiply.Location = new System.Drawing.Point(16, 137);
            this.rbtnMultiply.Name = "rbtnMultiply";
            this.rbtnMultiply.Size = new System.Drawing.Size(34, 21);
            this.rbtnMultiply.TabIndex = 2;
            this.rbtnMultiply.TabStop = true;
            this.rbtnMultiply.Text = "*";
            this.rbtnMultiply.UseVisualStyleBackColor = true;
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Location = new System.Drawing.Point(16, 184);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(33, 21);
            this.rbtnDivide.TabIndex = 3;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "/";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(164, 351);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(302, 60);
            this.btnPerform.TabIndex = 8;
            this.btnPerform.Text = "Perform Operation";
            this.btnPerform.UseVisualStyleBackColor = true;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 423);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnMultiply;
        private System.Windows.Forms.RadioButton rbtnMinus;
        private System.Windows.Forms.RadioButton rbtnPlus;
        private System.Windows.Forms.Button btnPerform;
    }
}

