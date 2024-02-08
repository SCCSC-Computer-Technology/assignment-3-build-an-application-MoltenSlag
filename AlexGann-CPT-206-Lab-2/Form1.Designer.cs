namespace AlexGann_CPT_206_Lab_2
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
            this.ChooseStateLabel = new System.Windows.Forms.Label();
            this.ChooseStateComboBox = new System.Windows.Forms.ComboBox();
            this.PopulationLabel = new System.Windows.Forms.Label();
            this.PopulationTextBox = new System.Windows.Forms.TextBox();
            this.CitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.ThirdLargestTextBox = new System.Windows.Forms.TextBox();
            this.ThirdLargestLabel = new System.Windows.Forms.Label();
            this.SecondLargestTextBox = new System.Windows.Forms.TextBox();
            this.SecondLargestLabel = new System.Windows.Forms.Label();
            this.LargestCityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CapitalTextBox = new System.Windows.Forms.TextBox();
            this.CapitalLabel = new System.Windows.Forms.Label();
            this.StateFlagDescriptionLabel = new System.Windows.Forms.Label();
            this.StateFlagDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SymbolsGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorsTextBox = new System.Windows.Forms.TextBox();
            this.ColorsLabel = new System.Windows.Forms.Label();
            this.BirdTextBox = new System.Windows.Forms.TextBox();
            this.BirdLabel = new System.Windows.Forms.Label();
            this.FlowerTextBox = new System.Windows.Forms.TextBox();
            this.FlowerLabel = new System.Windows.Forms.Label();
            this.CareerGroupBox = new System.Windows.Forms.GroupBox();
            this.PercentComputerJobsTextBox = new System.Windows.Forms.TextBox();
            this.PercentComputerJobsLabel = new System.Windows.Forms.Label();
            this.IncomeTextBox = new System.Windows.Forms.TextBox();
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.stateDatabaseDataSet = new AlexGann_CPT_206_Lab_2.StateDatabaseDataSet();
            this.CitiesGroupBox.SuspendLayout();
            this.SymbolsGroupBox.SuspendLayout();
            this.CareerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseStateLabel
            // 
            this.ChooseStateLabel.AutoSize = true;
            this.ChooseStateLabel.Location = new System.Drawing.Point(12, 9);
            this.ChooseStateLabel.Name = "ChooseStateLabel";
            this.ChooseStateLabel.Size = new System.Drawing.Size(115, 19);
            this.ChooseStateLabel.TabIndex = 0;
            this.ChooseStateLabel.Text = "Choose a State:";
            // 
            // ChooseStateComboBox
            // 
            this.ChooseStateComboBox.BackColor = System.Drawing.Color.Peru;
            this.ChooseStateComboBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.ChooseStateComboBox.FormattingEnabled = true;
            this.ChooseStateComboBox.Location = new System.Drawing.Point(12, 31);
            this.ChooseStateComboBox.Name = "ChooseStateComboBox";
            this.ChooseStateComboBox.Size = new System.Drawing.Size(250, 27);
            this.ChooseStateComboBox.TabIndex = 1;
            this.ChooseStateComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseStateComboBox_SelectedIndexChanged);
            // 
            // PopulationLabel
            // 
            this.PopulationLabel.AutoSize = true;
            this.PopulationLabel.Location = new System.Drawing.Point(12, 70);
            this.PopulationLabel.Name = "PopulationLabel";
            this.PopulationLabel.Size = new System.Drawing.Size(84, 19);
            this.PopulationLabel.TabIndex = 2;
            this.PopulationLabel.Text = "Population:";
            // 
            // PopulationTextBox
            // 
            this.PopulationTextBox.BackColor = System.Drawing.Color.Peru;
            this.PopulationTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.PopulationTextBox.Location = new System.Drawing.Point(12, 93);
            this.PopulationTextBox.Name = "PopulationTextBox";
            this.PopulationTextBox.ReadOnly = true;
            this.PopulationTextBox.Size = new System.Drawing.Size(250, 26);
            this.PopulationTextBox.TabIndex = 3;
            // 
            // CitiesGroupBox
            // 
            this.CitiesGroupBox.Controls.Add(this.ThirdLargestTextBox);
            this.CitiesGroupBox.Controls.Add(this.ThirdLargestLabel);
            this.CitiesGroupBox.Controls.Add(this.SecondLargestTextBox);
            this.CitiesGroupBox.Controls.Add(this.SecondLargestLabel);
            this.CitiesGroupBox.Controls.Add(this.LargestCityTextBox);
            this.CitiesGroupBox.Controls.Add(this.label1);
            this.CitiesGroupBox.Controls.Add(this.CapitalTextBox);
            this.CitiesGroupBox.Controls.Add(this.CapitalLabel);
            this.CitiesGroupBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.CitiesGroupBox.Location = new System.Drawing.Point(12, 126);
            this.CitiesGroupBox.Name = "CitiesGroupBox";
            this.CitiesGroupBox.Size = new System.Drawing.Size(250, 237);
            this.CitiesGroupBox.TabIndex = 4;
            this.CitiesGroupBox.TabStop = false;
            this.CitiesGroupBox.Text = "Notable Cities";
            // 
            // ThirdLargestTextBox
            // 
            this.ThirdLargestTextBox.BackColor = System.Drawing.Color.Peru;
            this.ThirdLargestTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.ThirdLargestTextBox.Location = new System.Drawing.Point(7, 202);
            this.ThirdLargestTextBox.Name = "ThirdLargestTextBox";
            this.ThirdLargestTextBox.ReadOnly = true;
            this.ThirdLargestTextBox.Size = new System.Drawing.Size(237, 26);
            this.ThirdLargestTextBox.TabIndex = 7;
            // 
            // ThirdLargestLabel
            // 
            this.ThirdLargestLabel.AutoSize = true;
            this.ThirdLargestLabel.Location = new System.Drawing.Point(7, 180);
            this.ThirdLargestLabel.Name = "ThirdLargestLabel";
            this.ThirdLargestLabel.Size = new System.Drawing.Size(106, 19);
            this.ThirdLargestLabel.TabIndex = 6;
            this.ThirdLargestLabel.Text = "Third Largest:";
            // 
            // SecondLargestTextBox
            // 
            this.SecondLargestTextBox.BackColor = System.Drawing.Color.Peru;
            this.SecondLargestTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.SecondLargestTextBox.Location = new System.Drawing.Point(7, 151);
            this.SecondLargestTextBox.Name = "SecondLargestTextBox";
            this.SecondLargestTextBox.ReadOnly = true;
            this.SecondLargestTextBox.Size = new System.Drawing.Size(237, 26);
            this.SecondLargestTextBox.TabIndex = 5;
            // 
            // SecondLargestLabel
            // 
            this.SecondLargestLabel.AutoSize = true;
            this.SecondLargestLabel.Location = new System.Drawing.Point(7, 129);
            this.SecondLargestLabel.Name = "SecondLargestLabel";
            this.SecondLargestLabel.Size = new System.Drawing.Size(118, 19);
            this.SecondLargestLabel.TabIndex = 4;
            this.SecondLargestLabel.Text = "Second Largest:";
            // 
            // LargestCityTextBox
            // 
            this.LargestCityTextBox.BackColor = System.Drawing.Color.Peru;
            this.LargestCityTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.LargestCityTextBox.Location = new System.Drawing.Point(7, 100);
            this.LargestCityTextBox.Name = "LargestCityTextBox";
            this.LargestCityTextBox.ReadOnly = true;
            this.LargestCityTextBox.Size = new System.Drawing.Size(237, 26);
            this.LargestCityTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Largest City:";
            // 
            // CapitalTextBox
            // 
            this.CapitalTextBox.BackColor = System.Drawing.Color.Peru;
            this.CapitalTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.CapitalTextBox.Location = new System.Drawing.Point(7, 49);
            this.CapitalTextBox.Name = "CapitalTextBox";
            this.CapitalTextBox.ReadOnly = true;
            this.CapitalTextBox.Size = new System.Drawing.Size(237, 26);
            this.CapitalTextBox.TabIndex = 1;
            // 
            // CapitalLabel
            // 
            this.CapitalLabel.AutoSize = true;
            this.CapitalLabel.Location = new System.Drawing.Point(7, 26);
            this.CapitalLabel.Name = "CapitalLabel";
            this.CapitalLabel.Size = new System.Drawing.Size(62, 19);
            this.CapitalLabel.TabIndex = 0;
            this.CapitalLabel.Text = "Capital:";
            // 
            // StateFlagDescriptionLabel
            // 
            this.StateFlagDescriptionLabel.AutoSize = true;
            this.StateFlagDescriptionLabel.Location = new System.Drawing.Point(269, 9);
            this.StateFlagDescriptionLabel.Name = "StateFlagDescriptionLabel";
            this.StateFlagDescriptionLabel.Size = new System.Drawing.Size(163, 19);
            this.StateFlagDescriptionLabel.TabIndex = 5;
            this.StateFlagDescriptionLabel.Text = "State Flag Description:";
            // 
            // StateFlagDescriptionTextBox
            // 
            this.StateFlagDescriptionTextBox.BackColor = System.Drawing.Color.Peru;
            this.StateFlagDescriptionTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.StateFlagDescriptionTextBox.Location = new System.Drawing.Point(270, 31);
            this.StateFlagDescriptionTextBox.Multiline = true;
            this.StateFlagDescriptionTextBox.Name = "StateFlagDescriptionTextBox";
            this.StateFlagDescriptionTextBox.ReadOnly = true;
            this.StateFlagDescriptionTextBox.Size = new System.Drawing.Size(300, 140);
            this.StateFlagDescriptionTextBox.TabIndex = 6;
            // 
            // SymbolsGroupBox
            // 
            this.SymbolsGroupBox.Controls.Add(this.ColorsTextBox);
            this.SymbolsGroupBox.Controls.Add(this.ColorsLabel);
            this.SymbolsGroupBox.Controls.Add(this.BirdTextBox);
            this.SymbolsGroupBox.Controls.Add(this.BirdLabel);
            this.SymbolsGroupBox.Controls.Add(this.FlowerTextBox);
            this.SymbolsGroupBox.Controls.Add(this.FlowerLabel);
            this.SymbolsGroupBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.SymbolsGroupBox.Location = new System.Drawing.Point(270, 177);
            this.SymbolsGroupBox.Name = "SymbolsGroupBox";
            this.SymbolsGroupBox.Size = new System.Drawing.Size(300, 186);
            this.SymbolsGroupBox.TabIndex = 7;
            this.SymbolsGroupBox.TabStop = false;
            this.SymbolsGroupBox.Text = "State Symbols";
            // 
            // ColorsTextBox
            // 
            this.ColorsTextBox.BackColor = System.Drawing.Color.Peru;
            this.ColorsTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.ColorsTextBox.Location = new System.Drawing.Point(6, 151);
            this.ColorsTextBox.Name = "ColorsTextBox";
            this.ColorsTextBox.ReadOnly = true;
            this.ColorsTextBox.Size = new System.Drawing.Size(288, 26);
            this.ColorsTextBox.TabIndex = 6;
            // 
            // ColorsLabel
            // 
            this.ColorsLabel.AutoSize = true;
            this.ColorsLabel.Location = new System.Drawing.Point(6, 129);
            this.ColorsLabel.Name = "ColorsLabel";
            this.ColorsLabel.Size = new System.Drawing.Size(97, 19);
            this.ColorsLabel.TabIndex = 5;
            this.ColorsLabel.Text = "State Colors:";
            // 
            // BirdTextBox
            // 
            this.BirdTextBox.BackColor = System.Drawing.Color.Peru;
            this.BirdTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.BirdTextBox.Location = new System.Drawing.Point(6, 100);
            this.BirdTextBox.Name = "BirdTextBox";
            this.BirdTextBox.ReadOnly = true;
            this.BirdTextBox.Size = new System.Drawing.Size(288, 26);
            this.BirdTextBox.TabIndex = 4;
            // 
            // BirdLabel
            // 
            this.BirdLabel.AutoSize = true;
            this.BirdLabel.Location = new System.Drawing.Point(6, 78);
            this.BirdLabel.Name = "BirdLabel";
            this.BirdLabel.Size = new System.Drawing.Size(82, 19);
            this.BirdLabel.TabIndex = 3;
            this.BirdLabel.Text = "State Bird:";
            // 
            // FlowerTextBox
            // 
            this.FlowerTextBox.BackColor = System.Drawing.Color.Peru;
            this.FlowerTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.FlowerTextBox.Location = new System.Drawing.Point(6, 48);
            this.FlowerTextBox.Name = "FlowerTextBox";
            this.FlowerTextBox.ReadOnly = true;
            this.FlowerTextBox.Size = new System.Drawing.Size(288, 26);
            this.FlowerTextBox.TabIndex = 2;
            // 
            // FlowerLabel
            // 
            this.FlowerLabel.AutoSize = true;
            this.FlowerLabel.Location = new System.Drawing.Point(6, 26);
            this.FlowerLabel.Name = "FlowerLabel";
            this.FlowerLabel.Size = new System.Drawing.Size(98, 19);
            this.FlowerLabel.TabIndex = 1;
            this.FlowerLabel.Text = "State Flower:";
            // 
            // CareerGroupBox
            // 
            this.CareerGroupBox.Controls.Add(this.PercentComputerJobsTextBox);
            this.CareerGroupBox.Controls.Add(this.PercentComputerJobsLabel);
            this.CareerGroupBox.Controls.Add(this.IncomeTextBox);
            this.CareerGroupBox.Controls.Add(this.IncomeLabel);
            this.CareerGroupBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.CareerGroupBox.Location = new System.Drawing.Point(12, 369);
            this.CareerGroupBox.Name = "CareerGroupBox";
            this.CareerGroupBox.Size = new System.Drawing.Size(558, 79);
            this.CareerGroupBox.TabIndex = 8;
            this.CareerGroupBox.TabStop = false;
            this.CareerGroupBox.Text = "Career Information";
            // 
            // PercentComputerJobsTextBox
            // 
            this.PercentComputerJobsTextBox.BackColor = System.Drawing.Color.Peru;
            this.PercentComputerJobsTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.PercentComputerJobsTextBox.Location = new System.Drawing.Point(282, 44);
            this.PercentComputerJobsTextBox.Name = "PercentComputerJobsTextBox";
            this.PercentComputerJobsTextBox.ReadOnly = true;
            this.PercentComputerJobsTextBox.Size = new System.Drawing.Size(270, 26);
            this.PercentComputerJobsTextBox.TabIndex = 9;
            // 
            // PercentComputerJobsLabel
            // 
            this.PercentComputerJobsLabel.AutoSize = true;
            this.PercentComputerJobsLabel.Location = new System.Drawing.Point(278, 22);
            this.PercentComputerJobsLabel.Name = "PercentComputerJobsLabel";
            this.PercentComputerJobsLabel.Size = new System.Drawing.Size(233, 19);
            this.PercentComputerJobsLabel.TabIndex = 8;
            this.PercentComputerJobsLabel.Text = "Percent of Computer-Based Jobs:";
            // 
            // IncomeTextBox
            // 
            this.IncomeTextBox.BackColor = System.Drawing.Color.Peru;
            this.IncomeTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.IncomeTextBox.Location = new System.Drawing.Point(6, 44);
            this.IncomeTextBox.Name = "IncomeTextBox";
            this.IncomeTextBox.ReadOnly = true;
            this.IncomeTextBox.Size = new System.Drawing.Size(270, 26);
            this.IncomeTextBox.TabIndex = 7;
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.AutoSize = true;
            this.IncomeLabel.Location = new System.Drawing.Point(6, 22);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(193, 19);
            this.IncomeLabel.TabIndex = 6;
            this.IncomeLabel.Text = "Average Employee Income:";
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(254, 454);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 30);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // stateDatabaseDataSet
            // 
            this.stateDatabaseDataSet.DataSetName = "StateDatabaseDataSet";
            this.stateDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(55)))));
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(582, 493);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CareerGroupBox);
            this.Controls.Add(this.SymbolsGroupBox);
            this.Controls.Add(this.StateFlagDescriptionTextBox);
            this.Controls.Add(this.StateFlagDescriptionLabel);
            this.Controls.Add(this.CitiesGroupBox);
            this.Controls.Add(this.PopulationTextBox);
            this.Controls.Add(this.PopulationLabel);
            this.Controls.Add(this.ChooseStateComboBox);
            this.Controls.Add(this.ChooseStateLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "AlexGann-CPT-206-Lab-2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CitiesGroupBox.ResumeLayout(false);
            this.CitiesGroupBox.PerformLayout();
            this.SymbolsGroupBox.ResumeLayout(false);
            this.SymbolsGroupBox.PerformLayout();
            this.CareerGroupBox.ResumeLayout(false);
            this.CareerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseStateLabel;
        private System.Windows.Forms.ComboBox ChooseStateComboBox;
        private System.Windows.Forms.Label PopulationLabel;
        private System.Windows.Forms.TextBox PopulationTextBox;
        private System.Windows.Forms.GroupBox CitiesGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CapitalTextBox;
        private System.Windows.Forms.Label CapitalLabel;
        private System.Windows.Forms.TextBox SecondLargestTextBox;
        private System.Windows.Forms.Label SecondLargestLabel;
        private System.Windows.Forms.TextBox LargestCityTextBox;
        private System.Windows.Forms.TextBox ThirdLargestTextBox;
        private System.Windows.Forms.Label ThirdLargestLabel;
        private System.Windows.Forms.Label StateFlagDescriptionLabel;
        private System.Windows.Forms.TextBox StateFlagDescriptionTextBox;
        private System.Windows.Forms.GroupBox SymbolsGroupBox;
        private System.Windows.Forms.TextBox BirdTextBox;
        private System.Windows.Forms.Label BirdLabel;
        private System.Windows.Forms.TextBox FlowerTextBox;
        private System.Windows.Forms.Label FlowerLabel;
        private System.Windows.Forms.TextBox ColorsTextBox;
        private System.Windows.Forms.Label ColorsLabel;
        private System.Windows.Forms.GroupBox CareerGroupBox;
        private System.Windows.Forms.TextBox IncomeTextBox;
        private System.Windows.Forms.Label IncomeLabel;
        private System.Windows.Forms.TextBox PercentComputerJobsTextBox;
        private System.Windows.Forms.Label PercentComputerJobsLabel;
        private System.Windows.Forms.Button ExitButton;
        private StateDatabaseDataSet stateDatabaseDataSet;
    }
}

