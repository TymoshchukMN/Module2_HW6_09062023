namespace Module2_HW6_09062023
{
    using System;
    using Module2_HW6_09062023.Enums;
    using Module2_HW6_09062023.Interfaces;

    public class Appliance : IEnergyConsuming, IPrintable, IComparable
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

        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }

        public virtual int GetEnergyConsuming()
        {
            int energyConsumption = 0;

            if (_isTurdedOn)
            {
                energyConsumption = _energyConsumption;
            }

            return energyConsumption;
        }

        public string PrintAllAppliance()
        {
            throw new NotImplementedException();
        }

        public string PrintTurnedOnAppliance()
        {
            if (_isTurdedOn)
            {
                return $"{this.GetType().Name}:\t{_manufacturer}:" +
                $"\t{_energyConsumption}";
            }
            else
            {
                return string.Empty;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}