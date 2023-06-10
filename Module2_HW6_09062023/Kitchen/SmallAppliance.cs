namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class SmallAppliance : Kitchen
    {
        private TypeMountAppliance _typeMountAppliance;

        public TypeMountAppliance TypeMountAppliance
        {
            get { return _typeMountAppliance; }
            set { _typeMountAppliance = value; }
        }

    }
}