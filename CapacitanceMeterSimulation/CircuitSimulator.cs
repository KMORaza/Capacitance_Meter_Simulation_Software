using System;
using System.Collections.Generic;

namespace CapacitanceMeterSimulation
{
    public class CircuitSimulator
    {
        private const double ChargeThreshold = 0.632; 
        private const double SupplyVoltage = 5.0; 
        private const double Amplitude = 5.0; 
        public double CalculateCapacitanceFromRC(double chargeTime, double resistance)
        {
            if (resistance <= 0 || chargeTime <= 0)
            {
                throw new ArgumentException("Resistance and charge time must be positive.");
            }
            /// τ = R * C, where τ is the time constant
            return chargeTime / resistance;
        }
        public double CalculateCapacitanceFromLC(double frequency, double inductance)
        {
            if (frequency <= 0 || inductance <= 0)
            {
                throw new ArgumentException("Frequency and inductance must be positive.");
            }
            /// f = 1 / (2π * sqrt(L * C))
            /// C = 1 / (4π² * f² * L)
            double c = 1 / (4 * Math.PI * Math.PI * frequency * frequency * inductance);
            return c;
        }
        public List<(double Time, double Voltage)> GenerateRCWaveform(double capacitance, double resistance)
        {
            var points = new List<(double Time, double Voltage)>();
            double tau = resistance * capacitance;
            double maxTime = 5 * tau; 
            int steps = 100;
            double dt = maxTime / steps;
            for (int i = 0; i <= steps; i++)
            {
                double t = i * dt;
                double voltage = SupplyVoltage * (1 - Math.Exp(-t / tau));
                points.Add((t, voltage));
            }
            return points;
        }
        public List<(double Time, double Voltage)> GenerateLCWaveform(double frequency)
        {
            var points = new List<(double Time, double Voltage)>();
            double period = 1 / frequency;
            double maxTime = 5 * period; 
            int steps = 100;
            double dt = maxTime / steps;
            for (int i = 0; i <= steps; i++)
            {
                double t = i * dt;
                double voltage = Amplitude * Math.Sin(2 * Math.PI * frequency * t);
                points.Add((t, voltage));
            }
            return points;
        }
    }
}