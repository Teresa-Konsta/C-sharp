namespace VehicleApp
{
    partial class FrmVehicles
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
            this.grpVehicleInformation = new System.Windows.Forms.GroupBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.rbtnBicycle = new System.Windows.Forms.RadioButton();
            this.rbtnCar = new System.Windows.Forms.RadioButton();
            this.grpBikes = new System.Windows.Forms.GroupBox();
            this.cboTerrain = new System.Windows.Forms.ComboBox();
            this.nrudTireSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpCars = new System.Windows.Forms.GroupBox();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.nrudPassengers = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.grpVehicleInformation.SuspendLayout();
            this.grpVehicle.SuspendLayout();
            this.grpBikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).BeginInit();
            this.grpCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVehicleInformation
            // 
            this.grpVehicleInformation.Controls.Add(this.txtStore);
            this.grpVehicleInformation.Controls.Add(this.txtWarranty);
            this.grpVehicleInformation.Controls.Add(this.txtPrice);
            this.grpVehicleInformation.Controls.Add(this.txtBrand);
            this.grpVehicleInformation.Controls.Add(this.txtName);
            this.grpVehicleInformation.Controls.Add(this.label5);
            this.grpVehicleInformation.Controls.Add(this.label4);
            this.grpVehicleInformation.Controls.Add(this.label3);
            this.grpVehicleInformation.Controls.Add(this.label2);
            this.grpVehicleInformation.Controls.Add(this.label1);
            this.grpVehicleInformation.Controls.Add(this.grpVehicle);
            this.grpVehicleInformation.Controls.Add(this.grpBikes);
            this.grpVehicleInformation.Controls.Add(this.grpCars);
            this.grpVehicleInformation.Location = new System.Drawing.Point(3, 93);
            this.grpVehicleInformation.Name = "grpVehicleInformation";
            this.grpVehicleInformation.Size = new System.Drawing.Size(866, 389);
            this.grpVehicleInformation.TabIndex = 0;
            this.grpVehicleInformation.TabStop = false;
            this.grpVehicleInformation.Text = "Vehicle Information";
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(117, 336);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(100, 22);
            this.txtStore.TabIndex = 11;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(117, 268);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(100, 22);
            this.txtWarranty.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(117, 206);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(117, 141);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Store:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Warranty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // grpVehicle
            // 
            this.grpVehicle.Controls.Add(this.rbtnBicycle);
            this.grpVehicle.Controls.Add(this.rbtnCar);
            this.grpVehicle.Location = new System.Drawing.Point(584, 47);
            this.grpVehicle.Name = "grpVehicle";
            this.grpVehicle.Size = new System.Drawing.Size(259, 158);
            this.grpVehicle.TabIndex = 1;
            this.grpVehicle.TabStop = false;
            this.grpVehicle.Text = "Type of Vehicle";
            // 
            // rbtnBicycle
            // 
            this.rbtnBicycle.AutoSize = true;
            this.rbtnBicycle.Location = new System.Drawing.Point(21, 104);
            this.rbtnBicycle.Name = "rbtnBicycle";
            this.rbtnBicycle.Size = new System.Drawing.Size(73, 21);
            this.rbtnBicycle.TabIndex = 1;
            this.rbtnBicycle.TabStop = true;
            this.rbtnBicycle.Text = "Bicycle";
            this.rbtnBicycle.UseVisualStyleBackColor = true;
            // 
            // rbtnCar
            // 
            this.rbtnCar.AutoSize = true;
            this.rbtnCar.Checked = true;
            this.rbtnCar.Location = new System.Drawing.Point(21, 51);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(51, 21);
            this.rbtnCar.TabIndex = 0;
            this.rbtnCar.TabStop = true;
            this.rbtnCar.Text = "Car";
            this.rbtnCar.UseVisualStyleBackColor = true;
            this.rbtnCar.CheckedChanged += new System.EventHandler(this.rbtnCar_CheckedChanged);
            // 
            // grpBikes
            // 
            this.grpBikes.Controls.Add(this.cboTerrain);
            this.grpBikes.Controls.Add(this.nrudTireSize);
            this.grpBikes.Controls.Add(this.label9);
            this.grpBikes.Controls.Add(this.label8);
            this.grpBikes.Enabled = false;
            this.grpBikes.Location = new System.Drawing.Point(274, 229);
            this.grpBikes.Name = "grpBikes";
            this.grpBikes.Size = new System.Drawing.Size(270, 152);
            this.grpBikes.TabIndex = 0;
            this.grpBikes.TabStop = false;
            this.grpBikes.Text = "For Bikes";
            // 
            // cboTerrain
            // 
            this.cboTerrain.FormattingEnabled = true;
            this.cboTerrain.Items.AddRange(new object[] {
            "Paved",
            "Unpaved"});
            this.cboTerrain.Location = new System.Drawing.Point(116, 112);
            this.cboTerrain.Name = "cboTerrain";
            this.cboTerrain.Size = new System.Drawing.Size(121, 24);
            this.cboTerrain.TabIndex = 15;
            // 
            // nrudTireSize
            // 
            this.nrudTireSize.Location = new System.Drawing.Point(116, 44);
            this.nrudTireSize.Name = "nrudTireSize";
            this.nrudTireSize.Size = new System.Drawing.Size(120, 22);
            this.nrudTireSize.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Terrain:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tire size:";
            // 
            // grpCars
            // 
            this.grpCars.Controls.Add(this.cboFuel);
            this.grpCars.Controls.Add(this.nrudPassengers);
            this.grpCars.Controls.Add(this.label7);
            this.grpCars.Controls.Add(this.label6);
            this.grpCars.Location = new System.Drawing.Point(274, 42);
            this.grpCars.Name = "grpCars";
            this.grpCars.Size = new System.Drawing.Size(270, 158);
            this.grpCars.TabIndex = 0;
            this.grpCars.TabStop = false;
            this.grpCars.Text = "For Cars";
            // 
            // cboFuel
            // 
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Items.AddRange(new object[] {
            "Gas",
            "Diesel",
            "Electric",
            "Hybrid"});
            this.cboFuel.Location = new System.Drawing.Point(116, 104);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(121, 24);
            this.cboFuel.TabIndex = 14;
            // 
            // nrudPassengers
            // 
            this.nrudPassengers.Location = new System.Drawing.Point(116, 31);
            this.nrudPassengers.Name = "nrudPassengers";
            this.nrudPassengers.Size = new System.Drawing.Size(120, 22);
            this.nrudPassengers.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fuel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Passengers:";
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Location = new System.Drawing.Point(649, 488);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(197, 68);
            this.btnCreateVehicle.TabIndex = 7;
            this.btnCreateVehicle.Text = "Create Vehicle";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(700, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 40);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(470, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 22);
            this.txtSearch.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Search by Vehicle Name:";
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Location = new System.Drawing.Point(18, 500);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(132, 56);
            this.btnMakeSale.TabIndex = 14;
            this.btnMakeSale.Text = "Make Sale";
            this.btnMakeSale.UseVisualStyleBackColor = true;
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Location = new System.Drawing.Point(194, 500);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(137, 56);
            this.btnCalculateInterest.TabIndex = 15;
            this.btnCalculateInterest.Text = "Calculate Interest";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            // 
            // FrmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 568);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.btnMakeSale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.grpVehicleInformation);
            this.Name = "FrmVehicles";
            this.Text = "Vehicles";
            this.grpVehicleInformation.ResumeLayout(false);
            this.grpVehicleInformation.PerformLayout();
            this.grpVehicle.ResumeLayout(false);
            this.grpVehicle.PerformLayout();
            this.grpBikes.ResumeLayout(false);
            this.grpBikes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).EndInit();
            this.grpCars.ResumeLayout(false);
            this.grpCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVehicleInformation;
        private System.Windows.Forms.GroupBox grpBikes;
        private System.Windows.Forms.GroupBox grpCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.RadioButton rbtnBicycle;
        private System.Windows.Forms.RadioButton rbtnCar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.NumericUpDown nrudTireSize;
        private System.Windows.Forms.NumericUpDown nrudPassengers;
        private System.Windows.Forms.ComboBox cboTerrain;
        private System.Windows.Forms.ComboBox cboFuel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMakeSale;
        private System.Windows.Forms.Button btnCalculateInterest;
    }
}

