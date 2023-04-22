using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace UniversalPipeCalculator
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;
        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["UniversalPipeCalculator.Properties.Settings.BoltsSetsConnectionString"].ConnectionString;

        }



        double pi = Math.PI;

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Material> material = new List<Material>();
            material.Add(new Material() { density = 7840, densityName = "Carbon steel" });
            material.Add(new Material() { density = 1450, densityName = "PVC" });
            material.Add(new Material() { density = 7860, densityName = "Pure iron" });
            material.Add(new Material() { density = 7750, densityName = "Wrought iron" });
            material.Add(new Material() { density = 7880, densityName = "Mild steel" });
            material.Add(new Material() { density = 8030, densityName = "Stainless steel" });
            material.Add(new Material() { density = 2700, densityName = "Aluminum" });
            material.Add(new Material() { density = 8500, densityName = "Brass" });
            material.Add(new Material() { density = 8960, densityName = "Copper" });
            materialComboBox.DataSource = material;
            materialComboBox.ValueMember = "density";
            materialComboBox.DisplayMember = "densityName";


            List<NominalDiameter> nominalDiameter = new List<NominalDiameter>();
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 10.2, nominalDiameterName = "DN6  (10,2)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 13.5, nominalDiameterName = "DN8  (13,5)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 17.2, nominalDiameterName = "DN10  (17,2)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 21.3, nominalDiameterName = "DN15  (21,3)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 26.9, nominalDiameterName = "DN20  (26,9)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 33.7, nominalDiameterName = "DN25  (33,7)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 42.4, nominalDiameterName = "DN32  (42,4)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 48.3, nominalDiameterName = "DN40  (48,3)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 60.3, nominalDiameterName = "DN50  (60,3)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 76.1, nominalDiameterName = "DN65  (76,1)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 88.9, nominalDiameterName = "DN80  (88,9)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 114.3, nominalDiameterName = "DN100  (114,3)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 139.7, nominalDiameterName = "DN125  (139,7)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 168.3, nominalDiameterName = "DN150  (168,3)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 219.1, nominalDiameterName = "DN200  (219,1)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 273.0, nominalDiameterName = "DN250  (273,0)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 323.9, nominalDiameterName = "DN300  (323,9)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 355.6, nominalDiameterName = "DN350  (355,6)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 406.4, nominalDiameterName = "DN400  (406,4)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 457.2, nominalDiameterName = "DN450  (457,2)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 508.0, nominalDiameterName = "DN500  (508,0)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 609.6, nominalDiameterName = "DN600  (609,6)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 711.2, nominalDiameterName = "DN700  (711,2)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 812.8, nominalDiameterName = "DN800  (812,8)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 914.4, nominalDiameterName = "DN900  (914,4)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 1016.0, nominalDiameterName = "DN1000  (1016,0)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 1220.0, nominalDiameterName = "DN1200  (1220,0)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 1420.0, nominalDiameterName = "DN1400  (1420,0)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 1620.0, nominalDiameterName = "DN1600  (1620,0)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 1820.0, nominalDiameterName = "DN1800  (1820,0)" });
            nominalDiameter.Add(new NominalDiameter() { nominalDiameter = 2020.0, nominalDiameterName = "DN1800  (2020,0)" });

            pipeNominalDiameterComboBox.DataSource = nominalDiameter;
            pipeNominalDiameterComboBox.ValueMember = "nominalDiameter";
            pipeNominalDiameterComboBox.DisplayMember = "nominalDiameterName";

            List<WallThickness> wallThickness = new List<WallThickness>();
            wallThickness.Add(new WallThickness() { wallThickness = 1.6, wallThicknessName = "1,6" });
            wallThickness.Add(new WallThickness() { wallThickness = 1.8, wallThicknessName = "1,8" });
            wallThickness.Add(new WallThickness() { wallThickness = 2.0, wallThicknessName = "2,0" });
            wallThickness.Add(new WallThickness() { wallThickness = 2.3, wallThicknessName = "2,3" });
            wallThickness.Add(new WallThickness() { wallThickness = 2.6, wallThicknessName = "2,6" });
            wallThickness.Add(new WallThickness() { wallThickness = 2.9, wallThicknessName = "2,9" });
            wallThickness.Add(new WallThickness() { wallThickness = 3.2, wallThicknessName = "3,2" });
            wallThickness.Add(new WallThickness() { wallThickness = 3.6, wallThicknessName = "3,6" });
            wallThickness.Add(new WallThickness() { wallThickness = 4.0, wallThicknessName = "4,0" });
            wallThickness.Add(new WallThickness() { wallThickness = 4.5, wallThicknessName = "4,5" });
            wallThickness.Add(new WallThickness() { wallThickness = 5.0, wallThicknessName = "5,0" });
            wallThickness.Add(new WallThickness() { wallThickness = 5.6, wallThicknessName = "5,6" });
            wallThickness.Add(new WallThickness() { wallThickness = 6.3, wallThicknessName = "6,3" });
            wallThickness.Add(new WallThickness() { wallThickness = 7.1, wallThicknessName = "7,1" });
            wallThickness.Add(new WallThickness() { wallThickness = 8.0, wallThicknessName = "8,0" });
            wallThickness.Add(new WallThickness() { wallThickness = 8.8, wallThicknessName = "8,8" });
            wallThickness.Add(new WallThickness() { wallThickness = 10.0, wallThicknessName = "10,0" });
            wallThickness.Add(new WallThickness() { wallThickness = 11.0, wallThicknessName = "11,0" });
            wallThickness.Add(new WallThickness() { wallThickness = 12.5, wallThicknessName = "12,5" });
            wallThickness.Add(new WallThickness() { wallThickness = 14.2, wallThicknessName = "14,2" });

            wallThicknessComboBox.DataSource = wallThickness;
            wallThicknessComboBox.ValueMember = "wallThickness";
            wallThicknessComboBox.DisplayMember = "wallThicknessName";

        }

        private void calculateButton2_Click(object sender, EventArgs e)
        {
            double pipeNominalDiameter = Convert.ToDouble(pipeNominalDiameterTextBox.Text);
            double wallThickness = Convert.ToDouble(wallThicknessTextBox.Text);
            double pipeLength2 = Convert.ToDouble(pipeLengthTextBox2.Text);
            int materialComboBoxValue = (int)materialComboBox.SelectedValue; //Ta wartość pobiera z comboBox.
            double pipeMassResult1 = Math.Pow((pipeNominalDiameter / 1000) / 2, 2);
            double pipeMassResult2 = Math.Pow(((pipeNominalDiameter / 1000) - 2 * (wallThickness / 1000)) / 2, 2);
            double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength2) * materialComboBoxValue;
            pipeMassResultLabel2.Text = pipeMassResult.ToString("N3");
        }

        private void calculateButton1_Click(object sender, EventArgs e)
        {
            double pipeNominalDiameterComboBoxValue = (double)pipeNominalDiameterComboBox.SelectedValue;
            double wallThicknessComboBoxValue = (double)wallThicknessComboBox.SelectedValue;
            double pipeLength1 = Convert.ToDouble(pipeLengthTextBox1.Text);
            int materialComboBoxValue = (int)materialComboBox.SelectedValue;
            double pipeMassResult1 = Math.Pow((pipeNominalDiameterComboBoxValue / 1000) / 2, 2);
            double pipeMassResult2 = Math.Pow(((pipeNominalDiameterComboBoxValue / 1000) - 2 * (wallThicknessComboBoxValue / 1000)) / 2, 2);
            double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength1) * materialComboBoxValue;
            pipeMassResultLabel1.Text = pipeMassResult.ToString("N3");
        }

        private void pipeNominalDiameterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void wallThicknessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pipeLengthTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pipeLengthTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

// Na dole pole które wyświetal np. "Wybrana rura to: DN25 (33,7 x 2,9 mm o długości 1 m - materiał Stal węglowa o gęstości 7840 kg/m3)
