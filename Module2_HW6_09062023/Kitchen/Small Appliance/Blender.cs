namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Blender : SmallAppliance
    {
        private const int _energyConsumption = 250;

        /// <summary>
        /// Наличие чаши в комплекте.
        /// </summary>
        private bool _bowlExist;

        public Blender(
            bool bowlExist,
            HousingMaterial housingMaterial,
            ColorAppliance color,
            Manufacturers manufacturer,
            bool isTurnedOn)
        {
            _bowlExist = bowlExist;
            HousingMaterial = housingMaterial;
            ColorAppliance = color;
            EnergyConsumption = _energyConsumption;
            Manufacturer = manufacturer;
            IsTurnedOn = isTurnedOn;
        }

        public bool BowlExist
        {
            get { return _bowlExist; }
            set { _bowlExist = value; }
        }
    }
}