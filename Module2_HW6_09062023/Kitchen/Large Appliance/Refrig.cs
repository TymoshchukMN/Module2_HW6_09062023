namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    /// <summary>
    /// Refrigirator.
    /// </summary>
    public class Refrig : LargeAppliance
    {
        private const int _energyConsumption = 570;
        private CoolingSystem _coolingSystem;

        public Refrig(
            CoolingSystem coolingSystem,
            TypeMountAppliance typeAppliance,
            ColorAppliance color,
            Manufacturers manufacturer,
            bool isTurnedOn)
        {
            CoolingSystem = coolingSystem;
            TypeAppliance = typeAppliance;
            ColorAppliance = color;
            EnergyConsumption = _energyConsumption;
            Manufacturer = manufacturer;
            IsTurnedOn = isTurnedOn;
        }

        public CoolingSystem CoolingSystem
        {
            get { return _coolingSystem; }
            set { _coolingSystem = value; }
        }
    }
}