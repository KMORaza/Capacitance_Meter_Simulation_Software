namespace CapacitanceMeterSimulation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelCapacitors = new System.Windows.Forms.Panel();
            this.lblCapacitance = new System.Windows.Forms.Label();
            this.txtCapacitance = new System.Windows.Forms.TextBox();
            this.btnAddCapacitor = new System.Windows.Forms.Button();
            this.btnRemoveCapacitor = new System.Windows.Forms.Button();
            this.lstCapacitors = new System.Windows.Forms.ListBox();
            this.lblConnected = new System.Windows.Forms.Label();
            this.panelCombination = new System.Windows.Forms.Panel();
            this.rbSeries = new System.Windows.Forms.RadioButton();
            this.rbParallel = new System.Windows.Forms.RadioButton();
            this.btnCalculateEquivalent = new System.Windows.Forms.Button();
            this.panelRC = new System.Windows.Forms.Panel();
            this.lblResistance = new System.Windows.Forms.Label();
            this.txtResistance = new System.Windows.Forms.TextBox();
            this.lblChargeTime = new System.Windows.Forms.Label();
            this.txtChargeTime = new System.Windows.Forms.TextBox();
            this.btnMeasureRC = new System.Windows.Forms.Button();
            this.panelLC = new System.Windows.Forms.Panel();
            this.lblInductance = new System.Windows.Forms.Label();
            this.txtInductance = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.btnMeasureLC = new System.Windows.Forms.Button();
            this.panelResult = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartWaveform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCapacitors.SuspendLayout();
            this.panelCombination.SuspendLayout();
            this.panelRC.SuspendLayout();
            this.panelLC.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).BeginInit();
            this.SuspendLayout();

            this.panelCapacitors.BackColor = System.Drawing.Color.Black;
            this.panelCapacitors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCapacitors.Controls.Add(this.lblConnected);
            this.panelCapacitors.Controls.Add(this.lstCapacitors);
            this.panelCapacitors.Controls.Add(this.btnRemoveCapacitor);
            this.panelCapacitors.Controls.Add(this.btnAddCapacitor);
            this.panelCapacitors.Controls.Add(this.txtCapacitance);
            this.panelCapacitors.Controls.Add(this.lblCapacitance);
            this.panelCapacitors.Location = new System.Drawing.Point(12, 12);
            this.panelCapacitors.Name = "panelCapacitors";
            this.panelCapacitors.Size = new System.Drawing.Size(400, 140);
            this.panelCapacitors.TabIndex = 0;

            this.lblCapacitance.AutoSize = true;
            this.lblCapacitance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacitance.ForeColor = System.Drawing.Color.White;
            this.lblCapacitance.Location = new System.Drawing.Point(10, 10);
            this.lblCapacitance.Name = "lblCapacitance";
            this.lblCapacitance.Size = new System.Drawing.Size(87, 14);
            this.lblCapacitance.TabIndex = 0;
            this.lblCapacitance.Text = "Capacitance (F):";

            this.txtCapacitance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCapacitance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacitance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCapacitance.Location = new System.Drawing.Point(110, 10);
            this.txtCapacitance.Name = "txtCapacitance";
            this.txtCapacitance.Size = new System.Drawing.Size(100, 20);
            this.txtCapacitance.TabIndex = 1;

            this.btnAddCapacitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddCapacitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCapacitor.ForeColor = System.Drawing.Color.White;
            this.btnAddCapacitor.Location = new System.Drawing.Point(220, 10);
            this.btnAddCapacitor.Name = "btnAddCapacitor";
            this.btnAddCapacitor.Size = new System.Drawing.Size(80, 25);
            this.btnAddCapacitor.TabIndex = 2;
            this.btnAddCapacitor.Text = "Connect";
            this.btnAddCapacitor.UseVisualStyleBackColor = false;
            this.btnAddCapacitor.Click += new System.EventHandler(this.btnAddCapacitor_Click);

            this.btnRemoveCapacitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoveCapacitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCapacitor.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCapacitor.Location = new System.Drawing.Point(310, 10);
            this.btnRemoveCapacitor.Name = "btnRemoveCapacitor";
            this.btnRemoveCapacitor.Size = new System.Drawing.Size(80, 25);
            this.btnRemoveCapacitor.TabIndex = 3;
            this.btnRemoveCapacitor.Text = "Disconnect";
            this.btnRemoveCapacitor.UseVisualStyleBackColor = false;
            this.btnRemoveCapacitor.Click += new System.EventHandler(this.btnRemoveCapacitor_Click);

            this.lstCapacitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstCapacitors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCapacitors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstCapacitors.FormattingEnabled = true;
            this.lstCapacitors.Location = new System.Drawing.Point(10, 40);
            this.lstCapacitors.Name = "lstCapacitors";
            this.lstCapacitors.Size = new System.Drawing.Size(380, 67);
            this.lstCapacitors.TabIndex = 4;

            this.lblConnected.AutoSize = true;
            this.lblConnected.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected.ForeColor = System.Drawing.Color.White;
            this.lblConnected.Location = new System.Drawing.Point(10, 115);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(87, 14);
            this.lblConnected.TabIndex = 5;
            this.lblConnected.Text = "Connected: 0/5";

            this.panelCombination.BackColor = System.Drawing.Color.Black;
            this.panelCombination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCombination.Controls.Add(this.btnCalculateEquivalent);
            this.panelCombination.Controls.Add(this.rbParallel);
            this.panelCombination.Controls.Add(this.rbSeries);
            this.panelCombination.Location = new System.Drawing.Point(12, 158);
            this.panelCombination.Name = "panelCombination";
            this.panelCombination.Size = new System.Drawing.Size(400, 80);
            this.panelCombination.TabIndex = 1;

            this.rbSeries.AutoSize = true;
            this.rbSeries.Checked = true;
            this.rbSeries.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSeries.ForeColor = System.Drawing.Color.White;
            this.rbSeries.Location = new System.Drawing.Point(10, 10);
            this.rbSeries.Name = "rbSeries";
            this.rbSeries.Size = new System.Drawing.Size(59, 18);
            this.rbSeries.TabIndex = 0;
            this.rbSeries.TabStop = true;
            this.rbSeries.Text = "Series";
            this.rbSeries.UseVisualStyleBackColor = true;

            this.rbParallel.AutoSize = true;
            this.rbParallel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbParallel.ForeColor = System.Drawing.Color.White;
            this.rbParallel.Location = new System.Drawing.Point(100, 10);
            this.rbParallel.Name = "rbParallel";
            this.rbParallel.Size = new System.Drawing.Size(73, 18);
            this.rbParallel.TabIndex = 1;
            this.rbParallel.Text = "Parallel";
            this.rbParallel.UseVisualStyleBackColor = true;

            this.btnCalculateEquivalent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalculateEquivalent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateEquivalent.ForeColor = System.Drawing.Color.White;
            this.btnCalculateEquivalent.Location = new System.Drawing.Point(10, 40);
            this.btnCalculateEquivalent.Name = "btnCalculateEquivalent";
            this.btnCalculateEquivalent.Size = new System.Drawing.Size(100, 25);
            this.btnCalculateEquivalent.TabIndex = 2;
            this.btnCalculateEquivalent.Text = "Calculate";
            this.btnCalculateEquivalent.UseVisualStyleBackColor = false;
            this.btnCalculateEquivalent.Click += new System.EventHandler(this.btnCalculateEquivalent_Click);

            this.panelRC.BackColor = System.Drawing.Color.Black;
            this.panelRC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRC.Controls.Add(this.btnMeasureRC);
            this.panelRC.Controls.Add(this.txtChargeTime);
            this.panelRC.Controls.Add(this.lblChargeTime);
            this.panelRC.Controls.Add(this.txtResistance);
            this.panelRC.Controls.Add(this.lblResistance);
            this.panelRC.Location = new System.Drawing.Point(12, 244);
            this.panelRC.Name = "panelRC";
            this.panelRC.Size = new System.Drawing.Size(400, 100);
            this.panelRC.TabIndex = 2;

            this.lblResistance.AutoSize = true;
            this.lblResistance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResistance.ForeColor = System.Drawing.Color.White;
            this.lblResistance.Location = new System.Drawing.Point(10, 10);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(80, 14);
            this.lblResistance.TabIndex = 0;
            this.lblResistance.Text = "Resistance (Ω):";

            this.txtResistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtResistance.Location = new System.Drawing.Point(110, 10);
            this.txtResistance.Name = "txtResistance";
            this.txtResistance.Size = new System.Drawing.Size(100, 20);
            this.txtResistance.TabIndex = 1;

            this.lblChargeTime.AutoSize = true;
            this.lblChargeTime.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargeTime.ForeColor = System.Drawing.Color.White;
            this.lblChargeTime.Location = new System.Drawing.Point(10, 40);
            this.lblChargeTime.Name = "lblChargeTime";
            this.lblChargeTime.Size = new System.Drawing.Size(94, 14);
            this.lblChargeTime.TabIndex = 2;
            this.lblChargeTime.Text = "Charge Time (s):";

            this.txtChargeTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChargeTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChargeTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtChargeTime.Location = new System.Drawing.Point(110, 40);
            this.txtChargeTime.Name = "txtChargeTime";
            this.txtChargeTime.Size = new System.Drawing.Size(100, 20);
            this.txtChargeTime.TabIndex = 3;

            this.btnMeasureRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMeasureRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeasureRC.ForeColor = System.Drawing.Color.White;
            this.btnMeasureRC.Location = new System.Drawing.Point(10, 70);
            this.btnMeasureRC.Name = "btnMeasureRC";
            this.btnMeasureRC.Size = new System.Drawing.Size(100, 25);
            this.btnMeasureRC.TabIndex = 4;
            this.btnMeasureRC.Text = "Measure RC";
            this.btnMeasureRC.UseVisualStyleBackColor = false;
            this.btnMeasureRC.Click += new System.EventHandler(this.btnMeasureRC_Click);

            this.panelLC.BackColor = System.Drawing.Color.Black;
            this.panelLC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLC.Controls.Add(this.btnMeasureLC);
            this.panelLC.Controls.Add(this.txtFrequency);
            this.panelLC.Controls.Add(this.lblFrequency);
            this.panelLC.Controls.Add(this.txtInductance);
            this.panelLC.Controls.Add(this.lblInductance);
            this.panelLC.Location = new System.Drawing.Point(12, 350);
            this.panelLC.Name = "panelLC";
            this.panelLC.Size = new System.Drawing.Size(400, 100);
            this.panelLC.TabIndex = 3;

            this.lblInductance.AutoSize = true;
            this.lblInductance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInductance.ForeColor = System.Drawing.Color.White;
            this.lblInductance.Location = new System.Drawing.Point(10, 10);
            this.lblInductance.Name = "lblInductance";
            this.lblInductance.Size = new System.Drawing.Size(80, 14);
            this.lblInductance.TabIndex = 0;
            this.lblInductance.Text = "Inductance (H):";

            this.txtInductance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInductance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInductance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtInductance.Location = new System.Drawing.Point(110, 10);
            this.txtInductance.Name = "txtInductance";
            this.txtInductance.Size = new System.Drawing.Size(100, 20);
            this.txtInductance.TabIndex = 1;

            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.ForeColor = System.Drawing.Color.White;
            this.lblFrequency.Location = new System.Drawing.Point(10, 40);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(80, 14);
            this.lblFrequency.TabIndex = 2;
            this.lblFrequency.Text = "Frequency (Hz):";

            this.txtFrequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFrequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFrequency.Location = new System.Drawing.Point(110, 40);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtFrequency.TabIndex = 3;

            this.btnMeasureLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMeasureLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeasureLC.ForeColor = System.Drawing.Color.White;
            this.btnMeasureLC.Location = new System.Drawing.Point(10, 70);
            this.btnMeasureLC.Name = "btnMeasureLC";
            this.btnMeasureLC.Size = new System.Drawing.Size(100, 25);
            this.btnMeasureLC.TabIndex = 4;
            this.btnMeasureLC.Text = "Measure LC";
            this.btnMeasureLC.UseVisualStyleBackColor = false;
            this.btnMeasureLC.Click += new System.EventHandler(this.btnMeasureLC_Click);

            this.panelResult.BackColor = System.Drawing.Color.Black;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelResult.Controls.Add(this.lblResult);
            this.panelResult.Location = new System.Drawing.Point(12, 456);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(400, 100);
            this.panelResult.TabIndex = 4;

            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblResult.Location = new System.Drawing.Point(10, 10);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 14);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result:";

            this.panelChart.BackColor = System.Drawing.Color.Black;
            this.panelChart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChart.Controls.Add(this.chartWaveform);
            this.panelChart.Location = new System.Drawing.Point(12, 562);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(400, 200);
            this.panelChart.TabIndex = 5;

            chartArea1.Name = "ChartArea1";
            this.chartWaveform.ChartAreas.Add(chartArea1);
            this.chartWaveform.Location = new System.Drawing.Point(10, 10);
            this.chartWaveform.Name = "chartWaveform";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Waveform";
            this.chartWaveform.Series.Add(series1);
            this.chartWaveform.Size = new System.Drawing.Size(380, 180);
            this.chartWaveform.TabIndex = 0;
            this.chartWaveform.Text = "chartWaveform";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(424, 774);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelLC);
            this.Controls.Add(this.panelRC);
            this.Controls.Add(this.panelCombination);
            this.Controls.Add(this.panelCapacitors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Capacitance Meter v1.0";
            this.panelCapacitors.ResumeLayout(false);
            this.panelCapacitors.PerformLayout();
            this.panelCombination.ResumeLayout(false);
            this.panelCombination.PerformLayout();
            this.panelRC.ResumeLayout(false);
            this.panelRC.PerformLayout();
            this.panelLC.ResumeLayout(false);
            this.panelLC.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelCapacitors;
        private System.Windows.Forms.Label lblCapacitance;
        private System.Windows.Forms.TextBox txtCapacitance;
        private System.Windows.Forms.Button btnAddCapacitor;
        private System.Windows.Forms.Button btnRemoveCapacitor;
        private System.Windows.Forms.ListBox lstCapacitors;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Panel panelCombination;
        private System.Windows.Forms.RadioButton rbSeries;
        private System.Windows.Forms.RadioButton rbParallel;
        private System.Windows.Forms.Button btnCalculateEquivalent;
        private System.Windows.Forms.Panel panelRC;
        private System.Windows.Forms.Label lblResistance;
        private System.Windows.Forms.TextBox txtResistance;
        private System.Windows.Forms.Label lblChargeTime;
        private System.Windows.Forms.TextBox txtChargeTime;
        private System.Windows.Forms.Button btnMeasureRC;
        private System.Windows.Forms.Panel panelLC;
        private System.Windows.Forms.Label lblInductance;
        private System.Windows.Forms.TextBox txtInductance;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Button btnMeasureLC;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaveform;
    }
}