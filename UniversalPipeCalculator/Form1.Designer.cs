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
            this.label1 = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.pipeLengthTextBox = new System.Windows.Forms.TextBox();
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
            this.pipeLengthComboBox = new System.Windows.Forms.ComboBox();
            this.pipeLenghtLabel1 = new System.Windows.Forms.Label();
            this.wallThicknessComboBox = new System.Windows.Forms.ComboBox();
            this.wallThicknessLabel1 = new System.Windows.Forms.Label();
            this.pipeNominalDiameterComboBox = new System.Windows.Forms.ComboBox();
            this.nominalDiameterLabel1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pipeCalculatorTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.materialComboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.calculateButton);
            this.tabPage1.Controls.Add(this.pipeLengthTextBox);
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
            this.tabPage1.Controls.Add(this.pipeLengthComboBox);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(940, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Konfigurator";
            // 
            // materialComboBox
            // 
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
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Materiał";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(480, 509);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(189, 52);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Licz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pipeLengthTextBox
            // 
            this.pipeLengthTextBox.Location = new System.Drawing.Point(480, 334);
            this.pipeLengthTextBox.Name = "pipeLengthTextBox";
            this.pipeLengthTextBox.Size = new System.Drawing.Size(188, 26);
            this.pipeLengthTextBox.TabIndex = 17;
            // 
            // wallThicknessTextBox
            // 
            this.wallThicknessTextBox.Location = new System.Drawing.Point(480, 232);
            this.wallThicknessTextBox.Name = "wallThicknessTextBox";
            this.wallThicknessTextBox.Size = new System.Drawing.Size(188, 26);
            this.wallThicknessTextBox.TabIndex = 16;
            // 
            // pipeNominalDiameterTextBox
            // 
            this.pipeNominalDiameterTextBox.Location = new System.Drawing.Point(480, 132);
            this.pipeNominalDiameterTextBox.Name = "pipeNominalDiameterTextBox";
            this.pipeNominalDiameterTextBox.Size = new System.Drawing.Size(188, 26);
            this.pipeNominalDiameterTextBox.TabIndex = 15;
            // 
            // manualValueEnteringLabel
            // 
            this.manualValueEnteringLabel.AutoSize = true;
            this.manualValueEnteringLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manualValueEnteringLabel.Location = new System.Drawing.Point(480, 32);
            this.manualValueEnteringLabel.Name = "manualValueEnteringLabel";
            this.manualValueEnteringLabel.Size = new System.Drawing.Size(169, 20);
            this.manualValueEnteringLabel.TabIndex = 14;
            this.manualValueEnteringLabel.Text = "Ręczne wprowadzanie";
            // 
            // pipeMassResultLabel2
            // 
            this.pipeMassResultLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pipeMassResultLabel2.Location = new System.Drawing.Point(480, 428);
            this.pipeMassResultLabel2.Name = "pipeMassResultLabel2";
            this.pipeMassResultLabel2.Size = new System.Drawing.Size(188, 28);
            this.pipeMassResultLabel2.TabIndex = 13;
            this.pipeMassResultLabel2.Click += new System.EventHandler(this.pipeMassResultLabel2_Click);
            // 
            // pipeMassLabel2
            // 
            this.pipeMassLabel2.AutoSize = true;
            this.pipeMassLabel2.Location = new System.Drawing.Point(480, 392);
            this.pipeMassLabel2.Name = "pipeMassLabel2";
            this.pipeMassLabel2.Size = new System.Drawing.Size(107, 20);
            this.pipeMassLabel2.TabIndex = 12;
            this.pipeMassLabel2.Text = "Masa rury [kg]";
            // 
            // pipeLenghtLabel2
            // 
            this.pipeLenghtLabel2.AutoSize = true;
            this.pipeLenghtLabel2.Location = new System.Drawing.Point(480, 292);
            this.pipeLenghtLabel2.Name = "pipeLenghtLabel2";
            this.pipeLenghtLabel2.Size = new System.Drawing.Size(193, 20);
            this.pipeLenghtLabel2.TabIndex = 11;
            this.pipeLenghtLabel2.Text = "Długość całkowita rury [m]";
            // 
            // wallThicknessLabel2
            // 
            this.wallThicknessLabel2.AutoSize = true;
            this.wallThicknessLabel2.Location = new System.Drawing.Point(480, 192);
            this.wallThicknessLabel2.Name = "wallThicknessLabel2";
            this.wallThicknessLabel2.Size = new System.Drawing.Size(160, 20);
            this.wallThicknessLabel2.TabIndex = 10;
            this.wallThicknessLabel2.Text = "Grubość ścianki [mm]";
            // 
            // nominalDiameterLabel2
            // 
            this.nominalDiameterLabel2.AutoSize = true;
            this.nominalDiameterLabel2.Location = new System.Drawing.Point(480, 92);
            this.nominalDiameterLabel2.Name = "nominalDiameterLabel2";
            this.nominalDiameterLabel2.Size = new System.Drawing.Size(176, 20);
            this.nominalDiameterLabel2.TabIndex = 9;
            this.nominalDiameterLabel2.Text = "Średnica nominalna DN";
            // 
            // pipeConfiguratorLabel
            // 
            this.pipeConfiguratorLabel.AutoSize = true;
            this.pipeConfiguratorLabel.Location = new System.Drawing.Point(20, 32);
            this.pipeConfiguratorLabel.Name = "pipeConfiguratorLabel";
            this.pipeConfiguratorLabel.Size = new System.Drawing.Size(107, 20);
            this.pipeConfiguratorLabel.TabIndex = 8;
            this.pipeConfiguratorLabel.Text = "Wybierz z listy";
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
            this.pipeMassLabel1.Size = new System.Drawing.Size(107, 20);
            this.pipeMassLabel1.TabIndex = 6;
            this.pipeMassLabel1.Text = "Masa rury [kg]";
            // 
            // pipeLengthComboBox
            // 
            this.pipeLengthComboBox.FormattingEnabled = true;
            this.pipeLengthComboBox.Location = new System.Drawing.Point(25, 332);
            this.pipeLengthComboBox.Name = "pipeLengthComboBox";
            this.pipeLengthComboBox.Size = new System.Drawing.Size(188, 28);
            this.pipeLengthComboBox.TabIndex = 5;
            // 
            // pipeLenghtLabel1
            // 
            this.pipeLenghtLabel1.AutoSize = true;
            this.pipeLenghtLabel1.Location = new System.Drawing.Point(20, 292);
            this.pipeLenghtLabel1.Name = "pipeLenghtLabel1";
            this.pipeLenghtLabel1.Size = new System.Drawing.Size(193, 20);
            this.pipeLenghtLabel1.TabIndex = 4;
            this.pipeLenghtLabel1.Text = "Długość całkowita rury [m]";
            // 
            // wallThicknessComboBox
            // 
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
            this.wallThicknessLabel1.Size = new System.Drawing.Size(160, 20);
            this.wallThicknessLabel1.TabIndex = 2;
            this.wallThicknessLabel1.Text = "Grubość ścianki [mm]";
            // 
            // pipeNominalDiameterComboBox
            // 
            this.pipeNominalDiameterComboBox.FormattingEnabled = true;
            this.pipeNominalDiameterComboBox.Location = new System.Drawing.Point(25, 132);
            this.pipeNominalDiameterComboBox.Name = "pipeNominalDiameterComboBox";
            this.pipeNominalDiameterComboBox.Size = new System.Drawing.Size(188, 28);
            this.pipeNominalDiameterComboBox.TabIndex = 1;
            this.pipeNominalDiameterComboBox.SelectedIndexChanged += new System.EventHandler(this.pipeNominalDiameterComboBox_SelectedIndexChanged);
            // 
            // nominalDiameterLabel1
            // 
            this.nominalDiameterLabel1.AutoSize = true;
            this.nominalDiameterLabel1.Location = new System.Drawing.Point(20, 92);
            this.nominalDiameterLabel1.Name = "nominalDiameterLabel1";
            this.nominalDiameterLabel1.Size = new System.Drawing.Size(176, 20);
            this.nominalDiameterLabel1.TabIndex = 0;
            this.nominalDiameterLabel1.Text = "Średnica nominalna DN";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1219, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ComboBox pipeLengthComboBox;
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
        private System.Windows.Forms.TextBox pipeLengthTextBox;
        private System.Windows.Forms.TextBox wallThicknessTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label label2;
    }
}

