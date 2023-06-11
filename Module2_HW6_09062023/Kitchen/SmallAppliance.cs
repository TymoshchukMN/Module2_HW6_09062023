namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class SmallAppliance : Kitchen
    {
        private HousingMaterial _housingMaterial;

        public HousingMaterial HousingMaterial
        {
            get { return _housingMaterial; }
            set { _housingMaterial = value; }
        }
    }
}