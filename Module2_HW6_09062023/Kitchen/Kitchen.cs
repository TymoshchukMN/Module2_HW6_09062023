namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public abstract class Kitchen : Appliance
    {
        protected Color _colorAppliance;

        public Color ColorAppliance
        {
            get { return _colorAppliance; }
            set { _colorAppliance = value; }
        }
    }
}