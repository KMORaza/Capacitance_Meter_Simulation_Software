using System;
using System.Collections.Generic;

namespace CapacitanceMeterSimulation
{
    public class CapacitanceCalculator
    {
        public double CalculateSeries(List<double> capacitances)
        {
            if (capacitances == null || capacitances.Count == 0)
            {
                throw new ArgumentException("No capacitors provided.");
            }
            double reciprocalSum = 0;
            foreach (double c in capacitances)
            {
                if (c <= 0)
                {
                    throw new ArgumentException("Capacitance must be positive.");
                }
                reciprocalSum += 1 / c;
            }
            return 1 / reciprocalSum;
        }
        public double CalculateParallel(List<double> capacitances)
        {
            if (capacitances == null || capacitances.Count == 0)
            {
                throw new ArgumentException("No capacitors provided.");
            }
            double sum = 0;
            foreach (double c in capacitances)
            {
                if (c < 0)
                {
                    throw new ArgumentException("Capacitance cannot be negative.");
                }
                sum += c;
            }
            return sum;
        }
    }
}