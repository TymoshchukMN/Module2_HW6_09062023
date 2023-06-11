namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Refrigerator : LargeAppliance
    {
        private CoolingSystem _coolingSystem;

        public Refrigerator(
            CoolingSystem coolingSystem,
            TypeMountAppliance typeAppliance,
            Color color,
            int energyConsumption,
            Manufacturers manufacturer,
            int voltage)
        {
            CoolingSystem = coolingSystem;
            TypeAppliance = typeAppliance;
            ColorAppliance = color;
            EnergyConsumption = energyConsumption;
            Manufacturer = manufacturer;
            Voltage = voltage;
        }

        public CoolingSystem CoolingSystem
        {
            get { return _coolingSystem; }
            set { _coolingSystem = value; }
        }
    }
}