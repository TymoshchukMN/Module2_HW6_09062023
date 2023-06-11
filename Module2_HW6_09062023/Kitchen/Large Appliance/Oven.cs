namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Oven : LargeAppliance
    {
        private ControlType _controlType;

        public Oven(
            ControlType controlType,
            TypeMountAppliance typeAppliance,
            Color color,
            int energyConsumption,
            Manufacturers manufacturer,
            int voltage)
        {
            _controlType = controlType;
            TypeAppliance = typeAppliance;
            ColorAppliance = color;
            EnergyConsumption = energyConsumption;
            Manufacturer = manufacturer;
            Voltage = voltage;
        }

        public ControlType ControlType
        {
            get { return _controlType; }
            set { _controlType = value; }
        }
    }
}