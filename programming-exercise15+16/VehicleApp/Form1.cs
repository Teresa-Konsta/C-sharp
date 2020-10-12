using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class FrmVehicles : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private Vehicle myVehicle;

        public FrmVehicles()
        {
            InitializeComponent();
        }

        private void rbtnCar_CheckedChanged(object sender, EventArgs e)
        {
            grpCars.Enabled = rbtnCar.Checked;
            grpBikes.Enabled = rbtnBicycle.Checked;
            //grpBikes.Enabled = !rbtnCar.Checked;

            //if (rbtnCar.Checked)
            //{ 
            //    grpBikes.Enabled = false;
            //    grpCars.Enabled = true;
            //}
            //else if (rbtnBicycle.Checked)
            //{ 
            //    grpBikes.Enabled = true;
            //    grpCars.Enabled = false;
            //}
        }

        public void ClearControls()
        {
            txtName.Text = "";
            txtBrand.Text = "";
            txtPrice.Text = "";
            txtWarranty.Text = "";
            txtStore.Text = "";

            nrudPassengers.Value = 0;
            cboFuel.Text = "";

            nrudTireSize.Value = 0;
            cboTerrain.Text = "";

            rbtnCar.Checked = true;
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnBicycle.Checked)
                {
                    myVehicle = new Bicycle(txtName.Text, txtBrand.Text, double.Parse(txtPrice.Text), int.Parse(txtWarranty.Text),
                        txtStore.Text, (int)nrudTireSize.Value, cboTerrain.Text);
                }
                else
                {
                    myVehicle = new Car(txtName.Text, txtBrand.Text, double.Parse(txtPrice.Text), int.Parse(txtWarranty.Text),
                        txtStore.Text, (int)nrudPassengers.Value, cboFuel.Text);
                }
                vehicles.Add(myVehicle);
                MessageBox.Show(vehicles.ToString());
                MessageBox.Show($"Total number of vehicles: {vehicles.Count}");
                ClearControls();
                txtName.Focus();
            }
            //catch(ArgumentOutOfRangeException err) // if converting int to string -> it's format exception
            //{
            //    MessageBox.Show(err.Message);
            //}
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //grpVehicleInformation.Controls.Clear(); // gets rid of all controls in UI making it totally blank without any boxes
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControls();
                myVehicle = null;

                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Name.ToLower() == txtSearch.Text.ToLower())
                        myVehicle = vehicle;
                }

                txtName.Text = myVehicle.Name;
                txtBrand.Text = myVehicle.Brand;
                txtPrice.Text = myVehicle.Price.ToString();
                txtWarranty.Text = myVehicle.Warranty.ToString();
                txtStore.Text = myVehicle.Store;

                if (myVehicle.GetType() == typeof(Car))
                {
                    nrudPassengers.Value = ((Car)myVehicle).NumberOfPassengers;
                    cboFuel.Text = ((Car)myVehicle).Fuel;

                    rbtnCar.Checked = true;
                    rbtnBicycle.Checked = false;
                }
                else
                if (myVehicle.GetType() == typeof(Bicycle))
                {
                    nrudTireSize.Value = ((Bicycle)myVehicle).TireSize;
                    cboTerrain.Text = ((Bicycle)myVehicle).Terrain;

                    rbtnCar.Checked = false;
                    rbtnBicycle.Checked = true;
                }

                btnCalculateInterest.Enabled = true;
                btnMakeSale.Enabled = true;
            }
            catch (Exception)
            {
                ClearControls();
                MessageBox.Show("Vehicle not found!");
            }
        }

        private void btnMakeSale_Click(object sender, EventArgs e)
        {
            if (myVehicle != null)
                MessageBox.Show(myVehicle.MakeSale());
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            if (myVehicle != null)
                MessageBox.Show(myVehicle.CalculateInterest().ToString("c"));
        }
    }
}
