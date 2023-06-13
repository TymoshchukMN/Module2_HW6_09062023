namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public abstract class Kitchen : Appliance
    {
        private ColorAppliance _colorAppliance;

        public ColorAppliance ColorAppliance
        {
            get { return _colorAppliance; }
            set { _colorAppliance = value; }
        }
    }
}