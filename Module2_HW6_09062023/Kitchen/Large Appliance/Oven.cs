namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Oven : LargeAppliance
    {
        private const int _energyConsumption = 1200;
        private ControlType _controlType;

        public Oven(
            ControlType controlType,
            TypeMountAppliance typeAppliance,
            ColorAppliance color,
            Manufacturers manufacturer,
            bool isTurnedOn)
        {
            _controlType = controlType;
            TypeAppliance = typeAppliance;
            ColorAppliance = color;
            EnergyConsumption = _energyConsumption;
            Manufacturer = manufacturer;
            IsTurnedOn = isTurnedOn;
        }

        public ControlType ControlType
        {
            get { return _controlType; }
            set { _controlType = value; }
        }
    }
}