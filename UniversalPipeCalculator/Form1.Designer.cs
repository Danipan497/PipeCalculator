namespace UniversalPipeCalculator
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
            this.pipeCalculatorTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pipeLengthTextBox1 = new System.Windows.Forms.TextBox();
            this.calculateButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton2 = new System.Windows.Forms.Button();
            this.pipeLengthTextBox2 = new System.Windows.Forms.TextBox();
            this.wallThicknessTextBox = new System.Windows.Forms.TextBox();
            this.pipeNominalDiameterTextBox = new System.Windows.Forms.TextBox();
            this.manualValueEnteringLabel = new System.Windows.Forms.Label();
            this.pipeMassResultLabel2 = new System.Windows.Forms.Label();
            this.pipeMassLabel2 = new System.Windows.Forms.Label();
            this.pipeLenghtLabel2 = new System.Windows.Forms.Label();
            this.wallThicknessLabel2 = new System.Windows.Forms.Label();
            this.nominalDiameterLabel2 = new System.Windows.Forms.Label();
            this.pipeConfiguratorLabel = new System.Windows.Forms.Label();
            this.pipeMassResultLabel1 = new System.Windows.Forms.Label();
            this.pipeMassLabel1 = new System.Windows.Forms.Label();
            this.pipeLenghtLabel1 = new System.Windows.Forms.Label();
            this.wallThicknessComboBox = new System.Windows.Forms.ComboBox();
            this.wallThicknessLabel1 = new System.Windows.Forms.Label();
            this.pipeNominalDiameterComboBox = new System.Windows.Forms.ComboBox();
            this.nominalDiameterLabel1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pipeCalculatorTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pipeCalculatorTabs
            // 
            this.pipeCalculatorTabs.Controls.Add(this.tabPage1);
            this.pipeCalculatorTabs.Controls.Add(this.tabPage2);
            this.pipeCalculatorTabs.Location = new System.Drawing.Point(12, 12);
            this.pipeCalculatorTabs.Name = "pipeCalculatorTabs";
            this.pipeCalculatorTabs.SelectedIndex = 0;
            this.pipeCalculatorTabs.Size = new System.Drawing.Size(1227, 738);
            this.pipeCalculatorTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pipeLengthTextBox1);
            this.tabPage1.Controls.Add(this.calculateButton1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.materialComboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.calculateButton2);
            this.tabPage1.Controls.Add(this.pipeLengthTextBox2);
            this.tabPage1.Controls.Add(this.wallThicknessTextBox);
            this.tabPage1.Controls.Add(this.pipeNominalDiameterTextBox);
            this.tabPage1.Controls.Add(this.manualValueEnteringLabel);
            this.tabPage1.Controls.Add(this.pipeMassResultLabel2);
            this.tabPage1.Controls.Add(this.pipeMassLabel2);
            this.tabPage1.Controls.Add(this.pipeLenghtLabel2);
            this.tabPage1.Controls.Add(this.wallThicknessLabel2);
            this.tabPage1.Controls.Add(this.nominalDiameterLabel2);
            this.tabPage1.Controls.Add(this.pipeConfiguratorLabel);
            this.tabPage1.Controls.Add(this.pipeMassResultLabel1);
            this.tabPage1.Controls.Add(this.pipeMassLabel1);
            this.tabPage1.Controls.Add(this.pipeLenghtLabel1);
            this.tabPage1.Controls.Add(this.wallThicknessComboBox);
            this.tabPage1.Controls.Add(this.wallThicknessLabel1);
            this.tabPage1.Controls.Add(this.pipeNominalDiameterComboBox);
            this.tabPage1.Controls.Add(this.nominalDiameterLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1219, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pipe weight";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pipeLengthTextBox1
            // 
            this.pipeLengthTextBox1.Location = new System.Drawing.Point(25, 334);
            this.pipeLengthTextBox1.Name = "pipeLengthTextBox1";
            this.pipeLengthTextBox1.Size = new System.Drawing.Size(188, 26);
            this.pipeLengthTextBox1.TabIndex = 23;
            this.pipeLengthTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pipeLengthTextBox1_KeyPress);
            // 
            // calculateButton1
            // 
            this.calculateButton1.Location = new System.Drawing.Point(24, 509);
            this.calculateButton1.Name = "calculateButton1";
            this.calculateButton1.Size = new System.Drawing.Size(189, 52);
            this.calculateButton1.TabIndex = 22;
            this.calculateButton1.Text = "Count";
            this.calculateButton1.UseVisualStyleBackColor = true;
            this.calculateButton1.Click += new System.EventHandler(this.calculateButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(940, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Configurator";
            // 
            // materialComboBox
            // 
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(940, 132);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(188, 28);
            this.materialComboBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(940, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Material";
            // 
            // calculateButton2
            // 
            this.calculateButton2.Location = new System.Drawing.Point(480, 509);
            this.calculateButton2.Name = "calculateButton2";
            this.calculateButton2.Size = new System.Drawing.Size(189, 52);
            this.calculateButton2.TabIndex = 18;
            this.calculateButton2.Text = "Count";
            this.calculateButton2.UseVisualStyleBackColor = true;
            this.calculateButton2.Click += new System.EventHandler(this.calculateButton2_Click);
            // 
            // pipeLengthTextBox2
            // 
            this.pipeLengthTextBox2.Location = new System.Drawing.Point(480, 334);
            this.pipeLengthTextBox2.Name = "pipeLengthTextBox2";
            this.pipeLengthTextBox2.Size = new System.Drawing.Size(188, 26);
            this.pipeLengthTextBox2.TabIndex = 17;
            this.pipeLengthTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pipeLengthTextBox2_KeyPress);
            // 
            // wallThicknessTextBox
            // 
            this.wallThicknessTextBox.Location = new System.Drawing.Point(480, 232);
            this.wallThicknessTextBox.Name = "wallThicknessTextBox";
            this.wallThicknessTextBox.Size = new System.Drawing.Size(188, 26);
            this.wallThicknessTextBox.TabIndex = 16;
            this.wallThicknessTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wallThicknessTextBox_KeyPress);
            // 
            // pipeNominalDiameterTextBox
            // 
            this.pipeNominalDiameterTextBox.Location = new System.Drawing.Point(480, 132);
            this.pipeNominalDiameterTextBox.Name = "pipeNominalDiameterTextBox";
            this.pipeNominalDiameterTextBox.Size = new System.Drawing.Size(188, 26);
            this.pipeNominalDiameterTextBox.TabIndex = 15;
            this.pipeNominalDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pipeNominalDiameterTextBox_KeyPress);
            // 
            // manualValueEnteringLabel
            // 
            this.manualValueEnteringLabel.AutoSize = true;
            this.manualValueEnteringLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manualValueEnteringLabel.Location = new System.Drawing.Point(480, 32);
            this.manualValueEnteringLabel.Name = "manualValueEnteringLabel";
            this.manualValueEnteringLabel.Size = new System.Drawing.Size(61, 20);
            this.manualValueEnteringLabel.TabIndex = 14;
            this.manualValueEnteringLabel.Text = "Manual";
            // 
            // pipeMassResultLabel2
            // 
            this.pipeMassResultLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pipeMassResultLabel2.Location = new System.Drawing.Point(480, 428);
            this.pipeMassResultLabel2.Name = "pipeMassResultLabel2";
            this.pipeMassResultLabel2.Size = new System.Drawing.Size(188, 28);
            this.pipeMassResultLabel2.TabIndex = 13;
            // 
            // pipeMassLabel2
            // 
            this.pipeMassLabel2.AutoSize = true;
            this.pipeMassLabel2.Location = new System.Drawing.Point(480, 392);
            this.pipeMassLabel2.Name = "pipeMassLabel2";
            this.pipeMassLabel2.Size = new System.Drawing.Size(88, 20);
            this.pipeMassLabel2.TabIndex = 12;
            this.pipeMassLabel2.Text = "Weight [kg]";
            // 
            // pipeLenghtLabel2
            // 
            this.pipeLenghtLabel2.AutoSize = true;
            this.pipeLenghtLabel2.Location = new System.Drawing.Point(480, 292);
            this.pipeLenghtLabel2.Name = "pipeLenghtLabel2";
            this.pipeLenghtLabel2.Size = new System.Drawing.Size(84, 20);
            this.pipeLenghtLabel2.TabIndex = 11;
            this.pipeLenghtLabel2.Text = "Length [m]";
            // 
            // wallThicknessLabel2
            // 
            this.wallThicknessLabel2.AutoSize = true;
            this.wallThicknessLabel2.Location = new System.Drawing.Point(480, 192);
            this.wallThicknessLabel2.Name = "wallThicknessLabel2";
            this.wallThicknessLabel2.Size = new System.Drawing.Size(148, 20);
            this.wallThicknessLabel2.TabIndex = 10;
            this.wallThicknessLabel2.Text = "Wall thickness [mm]";
            // 
            // nominalDiameterLabel2
            // 
            this.nominalDiameterLabel2.AutoSize = true;
            this.nominalDiameterLabel2.Location = new System.Drawing.Point(480, 92);
            this.nominalDiameterLabel2.Name = "nominalDiameterLabel2";
            this.nominalDiameterLabel2.Size = new System.Drawing.Size(159, 20);
            this.nominalDiameterLabel2.TabIndex = 9;
            this.nominalDiameterLabel2.Text = "Nominal pipe size DN";
            // 
            // pipeConfiguratorLabel
            // 
            this.pipeConfiguratorLabel.AutoSize = true;
            this.pipeConfiguratorLabel.Location = new System.Drawing.Point(20, 32);
            this.pipeConfiguratorLabel.Name = "pipeConfiguratorLabel";
            this.pipeConfiguratorLabel.Size = new System.Drawing.Size(113, 20);
            this.pipeConfiguratorLabel.TabIndex = 8;
            this.pipeConfiguratorLabel.Text = "Select from list";
            // 
            // pipeMassResultLabel1
            // 
            this.pipeMassResultLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pipeMassResultLabel1.Location = new System.Drawing.Point(25, 428);
            this.pipeMassResultLabel1.Name = "pipeMassResultLabel1";
            this.pipeMassResultLabel1.Size = new System.Drawing.Size(188, 28);
            this.pipeMassResultLabel1.TabIndex = 7;
            // 
            // pipeMassLabel1
            // 
            this.pipeMassLabel1.AutoSize = true;
            this.pipeMassLabel1.Location = new System.Drawing.Point(20, 392);
            this.pipeMassLabel1.Name = "pipeMassLabel1";
            this.pipeMassLabel1.Size = new System.Drawing.Size(88, 20);
            this.pipeMassLabel1.TabIndex = 6;
            this.pipeMassLabel1.Text = "Weight [kg]";
            // 
            // pipeLenghtLabel1
            // 
            this.pipeLenghtLabel1.AutoSize = true;
            this.pipeLenghtLabel1.Location = new System.Drawing.Point(20, 292);
            this.pipeLenghtLabel1.Name = "pipeLenghtLabel1";
            this.pipeLenghtLabel1.Size = new System.Drawing.Size(84, 20);
            this.pipeLenghtLabel1.TabIndex = 4;
            this.pipeLenghtLabel1.Text = "Length [m]";
            // 
            // wallThicknessComboBox
            // 
            this.wallThicknessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wallThicknessComboBox.FormattingEnabled = true;
            this.wallThicknessComboBox.Location = new System.Drawing.Point(25, 232);
            this.wallThicknessComboBox.Name = "wallThicknessComboBox";
            this.wallThicknessComboBox.Size = new System.Drawing.Size(188, 28);
            this.wallThicknessComboBox.TabIndex = 3;
            // 
            // wallThicknessLabel1
            // 
            this.wallThicknessLabel1.AutoSize = true;
            this.wallThicknessLabel1.Location = new System.Drawing.Point(20, 192);
            this.wallThicknessLabel1.Name = "wallThicknessLabel1";
            this.wallThicknessLabel1.Size = new System.Drawing.Size(148, 20);
            this.wallThicknessLabel1.TabIndex = 2;
            this.wallThicknessLabel1.Text = "Wall thickness [mm]";
            // 
            // pipeNominalDiameterComboBox
            // 
            this.pipeNominalDiameterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pipeNominalDiameterComboBox.FormattingEnabled = true;
            this.pipeNominalDiameterComboBox.Location = new System.Drawing.Point(25, 132);
            this.pipeNominalDiameterComboBox.Name = "pipeNominalDiameterComboBox";
            this.pipeNominalDiameterComboBox.Size = new System.Drawing.Size(188, 28);
            this.pipeNominalDiameterComboBox.TabIndex = 1;
            // 
            // nominalDiameterLabel1
            // 
            this.nominalDiameterLabel1.AutoSize = true;
            this.nominalDiameterLabel1.Location = new System.Drawing.Point(20, 92);
            this.nominalDiameterLabel1.Name = "nominalDiameterLabel1";
            this.nominalDiameterLabel1.Size = new System.Drawing.Size(159, 20);
            this.nominalDiameterLabel1.TabIndex = 0;
            this.nominalDiameterLabel1.Text = "Nominal pipe size DN";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1219, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bolts weight";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select form list";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bolt size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity of nuts";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(25, 232);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 757);
            this.Controls.Add(this.pipeCalculatorTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Pipe calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pipeCalculatorTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pipeCalculatorTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label nominalDiameterLabel1;
        private System.Windows.Forms.ComboBox pipeNominalDiameterComboBox;
        private System.Windows.Forms.ComboBox wallThicknessComboBox;
        private System.Windows.Forms.Label wallThicknessLabel1;
        private System.Windows.Forms.Label pipeLenghtLabel1;
        private System.Windows.Forms.Label pipeMassResultLabel1;
        private System.Windows.Forms.Label pipeMassLabel1;
        private System.Windows.Forms.TextBox pipeNominalDiameterTextBox;
        private System.Windows.Forms.Label manualValueEnteringLabel;
        private System.Windows.Forms.Label pipeMassResultLabel2;
        private System.Windows.Forms.Label pipeMassLabel2;
        private System.Windows.Forms.Label pipeLenghtLabel2;
        private System.Windows.Forms.Label wallThicknessLabel2;
        private System.Windows.Forms.Label nominalDiameterLabel2;
        private System.Windows.Forms.Label pipeConfiguratorLabel;
        private System.Windows.Forms.TextBox pipeLengthTextBox2;
        private System.Windows.Forms.TextBox wallThicknessTextBox;
        private System.Windows.Forms.Button calculateButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton1;
        private System.Windows.Forms.TextBox pipeLengthTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
    }
}

