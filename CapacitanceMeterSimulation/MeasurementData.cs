using System;

namespace CapacitanceMeterSimulation
{
    public class MeasurementData
    {
        public double Capacitance { get; set; }
        public double? Voltage { get; set; }
        public double? Charge { get; set; }
        public double? Resistance { get; set; }
        public double? ChargeTime { get; set; }
        public double? Inductance { get; set; }
        public double? Frequency { get; set; }
        public string Method { get; set; }
        public DateTime Timestamp { get; set; }
    }
}