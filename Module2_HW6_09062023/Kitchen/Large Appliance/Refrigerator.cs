namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Refrigerator : LargeAppliance
    {
        private CoolingSystem _coolingSystem;

        public CoolingSystem CoolingSystem
        {
            get { return _coolingSystem; }
            set { _coolingSystem = value; }
        }
    }
}