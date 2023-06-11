namespace Module2_HW6_09062023
{
    using System;
    using Module2_HW6_09062023.Enums;

    public class Appliance
    {
        /// <summary>
        /// Напряжение.
        /// </summary>
        private int _voltage;

        /// <summary>
        /// Энергопотребление.
        /// </summary>
        private int _energyConsumption;

        private Manufacturers _manufacturer;

        public Manufacturers Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        public int EnergyConsumption
        {
            get { return _energyConsumption; }
            set { _energyConsumption = value; }
        }

        public int Voltage
        {
            get { return _voltage; }
            set { _voltage = value; }
        }
    }
}