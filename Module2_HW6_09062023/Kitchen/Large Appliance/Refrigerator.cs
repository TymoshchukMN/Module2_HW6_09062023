namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Refrigerator : LargeAppliance
    {
        private const int _energyConsumption = 570;
        private CoolingSystem _coolingSystem;

        public Refrigerator(
            CoolingSystem coolingSystem,
            TypeMountAppliance typeAppliance,
            ColorAppliance color,
            Manufacturers manufacturer)
        {
            CoolingSystem = coolingSystem;
            TypeAppliance = typeAppliance;
            ColorAppliance = color;
            EnergyConsumption = _energyConsumption;
            Manufacturer = manufacturer;
        }

        public CoolingSystem CoolingSystem
        {
            get { return _coolingSystem; }
            set { _coolingSystem = value; }
        }
    }
}