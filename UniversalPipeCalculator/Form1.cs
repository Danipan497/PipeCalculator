using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalPipeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pipeNominalDiameterComboBox.DataSource = Enum.GetValues(typeof(PipeNominalDiameter));


        }

        private void DisplayPipeMass()
        {
            //deklaracja zmiennej wynikowej = wynik masy rury
            //wywołanie etykiety pipeMassResultLabel 
        }

        private void pipeNominalDiameterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pipeMassResultLabel2_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double pipeNominalDiameter = Convert.ToDouble(pipeNominalDiameterTextBox.Text);
            double wallThickness = Convert.ToDouble(wallThicknessTextBox.Text);
            double pipeLength = Convert.ToDouble(pipeLengthTextBox.Text);
            double pi = Math.PI;
            int materialComboBoxValue = (int)materialComboBox.SelectedValue; //Ta wartość pobiera z comboBox.
            double pipeMassResult1 = Math.Pow((pipeNominalDiameter / 1000) / 2, 2);
            double pipeMassResult2 = Math.Pow(((pipeNominalDiameter / 1000) - 2 * (wallThickness / 1000)) / 2, 2);
            double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength) * materialComboBoxValue;
            pipeMassResultLabel2.Text = pipeMassResult.ToString("N3");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Material> material = new List<Material>();
            material.Add(new Material() { density = 7840, densityName = "Stal węglowaa" });
            material.Add(new Material() { density = 1450, densityName = "PVC" });
            material.Add(new Material() { density = 7860, densityName = "Czysta żelazo" });
            material.Add(new Material() { density = 7750, densityName = "Kute żelazo" });
            material.Add(new Material() { density = 7880, densityName = "Stal miękka" });
            material.Add(new Material() { density = 8030, densityName = "Stal nierdzewna" });
            material.Add(new Material() { density = 2700, densityName = "Aluminium" });
            material.Add(new Material() { density = 8500, densityName = "Mosiądz" });
            material.Add(new Material() { density = 8960, densityName = "Miedź" });
            materialComboBox.DataSource = material;
            materialComboBox.ValueMember = "density";
            materialComboBox.DisplayMember = "densityName";
        }
    }
}
