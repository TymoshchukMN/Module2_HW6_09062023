namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Blender : SmallAppliance
    {
        /// <summary>
        /// Наличие чаши в комплекте.
        /// </summary>
        private bool _bowlExist;

        public Blender(
            bool bowlExist,
            HousingMaterial housingMaterial,
            ColorAppliance color,
            int energyConsumption,
            Manufacturers manufacturer,
            int voltage)
        {
            _bowlExist = bowlExist;
            HousingMaterial = housingMaterial;
            ColorAppliance = color;
            EnergyConsumption = energyConsumption;
            Manufacturer = manufacturer;
            Voltage = voltage;
        }

        public bool BowlExist
        {
            get { return _bowlExist; }
            set { _bowlExist = value; }
        }
    }
}