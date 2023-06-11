namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Projector : Multimedia
    {
        private const int _energyConsumption = 210;
        private ProjectorInterfaceType _interfaceType;

        public Projector(
            Manufacturers manufacturer,
            TypeMountAppliance typeMountAppliance,
            ProjectorInterfaceType interfaceType,
            bool isTurnedOn)
        {
            EnergyConsumption = _energyConsumption;
            Manufacturer = manufacturer;
            TypeMountAppliance = typeMountAppliance;
            _interfaceType = interfaceType;
            IsTurnedOn = isTurnedOn;
        }

        public ProjectorInterfaceType InterfaceType
        {
            get { return _interfaceType; }
            set { _interfaceType = value; }
        }
    }
}