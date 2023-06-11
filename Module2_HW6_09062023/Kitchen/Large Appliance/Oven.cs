namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Oven : LargeAppliance
    {
        private ControlType _controlType;

        public ControlType ControlType
        {
            get { return _controlType; }
            set { _controlType = value; }
        }
    }
}