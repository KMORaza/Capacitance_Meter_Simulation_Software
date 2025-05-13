using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapacitanceMeterSimulation
{
    public partial class Form1 : Form
    {
        private readonly CapacitanceCalculator _calculator;
        private readonly CircuitSimulator _simulator;
        private readonly List<double> _capacitors;

        public Form1()
        {
            InitializeComponent();
            _calculator = new CapacitanceCalculator();
            _simulator = new CircuitSimulator();
            _capacitors = new List<double>();
            UpdateCapacitorList();
            InitializeChart();
            this.MaximizeBox = false; // Disable the maximize button
        }

        private void InitializeChart()
        {
            chartWaveform.ChartAreas[0].BackColor = Color.Black;
            chartWaveform.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartWaveform.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chartWaveform.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64);
            chartWaveform.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64);
            chartWaveform.Series[0].Color = Color.White;
            chartWaveform.Series[0].ChartType = SeriesChartType.Line;
            chartWaveform.Series[0].BorderWidth = 2;
        }

        private void UpdateCapacitorList()
        {
            lstCapacitors.Items.Clear();
            for (int i = 0; i < _capacitors.Count; i++)
            {
                lstCapacitors.Items.Add($"C{i + 1}: {_capacitors[i]:F6} F");
            }
            lblConnected.Text = $"Connected: {_capacitors.Count}/5";
        }

        private void btnAddCapacitor_Click(object sender, EventArgs e)
        {
            if (_capacitors.Count >= 5)
            {
                MessageBox.Show("Maximum 5 capacitors allowed.", "Limit Reached");
                return;
            }
            if (!double.TryParse(txtCapacitance.Text, out double capacitance) || capacitance <= 0)
            {
                MessageBox.Show("Enter a valid positive capacitance (Farads).", "Input Error");
                return;
            }
            _capacitors.Add(capacitance);
            UpdateCapacitorList();
            txtCapacitance.Clear();
        }

        private void btnRemoveCapacitor_Click(object sender, EventArgs e)
        {
            if (lstCapacitors.SelectedIndex >= 0)
            {
                _capacitors.RemoveAt(lstCapacitors.SelectedIndex);
                UpdateCapacitorList();
            }
            else
            {
                MessageBox.Show("Select a capacitor to remove.", "Selection Error");
            }
        }

        private void btnCalculateEquivalent_Click(object sender, EventArgs e)
        {
            if (_capacitors.Count == 0)
            {
                MessageBox.Show("No capacitors connected.", "Calculation Error");
                return;
            }
            double equivalent;
            if (rbSeries.Checked)
            {
                equivalent = _calculator.CalculateSeries(_capacitors);
            }
            else
            {
                equivalent = _calculator.CalculateParallel(_capacitors);
            }
            MeasurementData data = new MeasurementData
            {
                Capacitance = equivalent,
                Method = rbSeries.Checked ? "Series" : "Parallel",
                Timestamp = DateTime.Now
            };
            lblResult.Text = $"Equivalent Capacitance: {equivalent:F6} F\n" +
                             $"Mode: {data.Method}\n" +
                             $"Time: {data.Timestamp:HH:mm:ss}";
            chartWaveform.Series[0].Points.Clear();
        }

        private void btnMeasureRC_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtResistance.Text, out double resistance) || resistance <= 0)
            {
                MessageBox.Show("Enter a valid positive resistance (Ohms).", "Input Error");
                return;
            }
            if (!double.TryParse(txtChargeTime.Text, out double chargeTime) || chargeTime <= 0)
            {
                MessageBox.Show("Enter a valid positive charge time (seconds).", "Input Error");
                return;
            }
            double capacitance = _simulator.CalculateCapacitanceFromRC(chargeTime, resistance);
            MeasurementData data = new MeasurementData
            {
                Capacitance = capacitance,
                Resistance = resistance,
                ChargeTime = chargeTime,
                Method = "RC Time Constant",
                Timestamp = DateTime.Now
            };
            lblResult.Text = $"Capacitance: {capacitance:F6} F\n" +
                             $"Resistance: {resistance:F2} Ω\n" +
                             $"Charge Time: {chargeTime:F2} s\n" +
                             $"Method: {data.Method}\n" +
                             $"Time: {data.Timestamp:HH:mm:ss}";
            /// RC charging curve
            var points = _simulator.GenerateRCWaveform(capacitance, resistance);
            chartWaveform.Series[0].Points.Clear();
            foreach (var point in points)
            {
                chartWaveform.Series[0].Points.AddXY(point.Time, point.Voltage);
            }
            chartWaveform.ChartAreas[0].AxisX.Title = "Time (s)";
            chartWaveform.ChartAreas[0].AxisY.Title = "Voltage (V)";
        }

        private void btnMeasureLC_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInductance.Text, out double inductance) || inductance <= 0)
            {
                MessageBox.Show("Enter a valid positive inductance (Henries).", "Input Error");
                return;
            }
            if (!double.TryParse(txtFrequency.Text, out double frequency) || frequency <= 0)
            {
                MessageBox.Show("Enter a valid positive frequency (Hz).", "Input Error");
                return;
            }
            double capacitance = _simulator.CalculateCapacitanceFromLC(frequency, inductance);
            MeasurementData data = new MeasurementData
            {
                Capacitance = capacitance,
                Inductance = inductance,
                Frequency = frequency,
                Method = "LC Resonant Frequency",
                Timestamp = DateTime.Now
            };
            lblResult.Text = $"Capacitance: {capacitance:F6} F\n" +
                             $"Inductance: {inductance:F2} H\n" +
                             $"Frequency: {frequency:F2} Hz\n" +
                             $"Method: {data.Method}\n" +
                             $"Time: {data.Timestamp:HH:mm:ss}";

            /// LC oscillation
            var points = _simulator.GenerateLCWaveform(frequency);
            chartWaveform.Series[0].Points.Clear();
            foreach (var point in points)
            {
                chartWaveform.Series[0].Points.AddXY(point.Time, point.Voltage);
            }
            chartWaveform.ChartAreas[0].AxisX.Title = "Time (s)";
            chartWaveform.ChartAreas[0].AxisY.Title = "Voltage (V)";
        }
    }
}