using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_HW6_09062023
{
    public class Appliance
    {
        private int _voltage;

        private int _energyConsumption;

        private string _manufacturer;

        public string Manufacturer
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