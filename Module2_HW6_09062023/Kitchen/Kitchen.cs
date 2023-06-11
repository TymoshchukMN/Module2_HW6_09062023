namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public abstract class Kitchen : Appliance
    {
        private Color _color;

        public Color MyProperty
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}