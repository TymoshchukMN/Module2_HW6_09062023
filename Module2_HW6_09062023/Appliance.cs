﻿namespace Module2_HW6_09062023
{
    using System;
    using Module2_HW6_09062023.Enums;

    public class Appliance
    {
        /// <summary>
        /// Энергопотребление.
        /// </summary>
        private int _energyConsumption;

        private Manufacturers _manufacturer;

        private bool _isTurdedOn;

        public bool IsTurnedOn
        {
            get { return _isTurdedOn; }
            set { _isTurdedOn = value; }
        }

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
    }
}