namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class TV : Multimedia
    {
        private const int _energyConsumption = 90;
        private MatrixType _matrixType;

        public TV(
            Manufacturers manufacturer,
            TypeMountAppliance typeMountAppliance,
            MatrixType matrixType)
        {
            EnergyConsumption = _energyConsumption;
            Manufacturer = manufacturer;
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