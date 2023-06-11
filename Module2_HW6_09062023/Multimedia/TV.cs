namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class TV : Multimedia
    {
        private MatrixType _matrixType;

        public TV(
            int energyConsumption,
            Manufacturers manufacturer,
            int voltage,
            TypeMountAppliance typeMountAppliance,
            MatrixType matrixType)
        {
            EnergyConsumption = energyConsumption;
            Manufacturer = manufacturer;
            Voltage = voltage;
            TypeMountAppliance = typeMountAppliance;
            _matrixType = matrixType;
        }

        public MatrixType MatrixType
        {
            get { return _matrixType; }
            set { _matrixType = value; }
        }
    }
}