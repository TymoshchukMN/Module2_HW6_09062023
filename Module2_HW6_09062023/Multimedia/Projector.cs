namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Projector : Multimedia
    {
        private ProjectorInterfaceType _interfaceType;

        public Projector(
            int energyConsumption,
            Manufacturers manufacturer,
            int voltage,
            TypeMountAppliance typeMountAppliance,
            ProjectorInterfaceType interfaceType)
        {
            EnergyConsumption = energyConsumption;
            Manufacturer = manufacturer;
            Voltage = voltage;
            TypeMountAppliance = typeMountAppliance;
            _interfaceType = interfaceType;
        }

        public ProjectorInterfaceType InterfaceType
        {
            get { return _interfaceType; }
            set { _interfaceType = value; }
        }
    }
}